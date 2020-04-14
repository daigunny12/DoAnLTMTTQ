package Controller.QuanLy;

import Service.NhaCungCapService;
import Service.NhaCungCapServiceImpl;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;
import java.util.List;
import javax.swing.table.DefaultTableModel;
import Model.QuanLyNhaCungCapMod;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.RowFilter;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;
import view.Menu.QuanLyView.JFame.NhaCungCapJFame;
import Object.NhaCungCapObj;
import RendenrerInJTable.AlignRenderer;
import RendenrerInJTable.CurrencyRenderer;
import RendenrerInJTable.PhoneNumberRendenrer;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;
import javax.swing.table.TableCellRenderer;
import view.Menu.QuanLyView.NhaCungCapJPanel;

public class QuanLyNhaCungCapController {

    private JFrame nhaCungCapJFameThem;
    private JFrame nhaCungCapJFameSua;
    private JPanel pnView;
    private JButton btnAdd;
    private JTextField txtSearch;

    private NhaCungCapService nhaCungCapService = null;

    private String[] listColumn = {"STT", "Mã NCC", "Tên NCC", "Địa chỉ", "SDT", "Số nợ", "Ghi chú"};

    private TableRowSorter<TableModel> rowSorter = null;

    public TableCellRenderer alignRenderer = new AlignRenderer();

    public TableCellRenderer currencyRenderer = new CurrencyRenderer();

    public TableCellRenderer phoneNumberRendenrer = new PhoneNumberRendenrer();

    public QuanLyNhaCungCapController(JPanel pnView, JButton btnAdd, JTextField txtSearch) {
        this.pnView = pnView;
        this.btnAdd = btnAdd;
        this.txtSearch = txtSearch;

        this.nhaCungCapService = new NhaCungCapServiceImpl();
    }

    public void setDateToTable() {
        List<NhaCungCapObj> listItem = nhaCungCapService.getList();

        DefaultTableModel model = new QuanLyNhaCungCapMod().getTableNhaCungCap(listItem, listColumn);
        JTable table = new JTable(model);

        rowSorter = new TableRowSorter<>(table.getModel());
        table.setRowSorter(rowSorter);

        txtSearch.getDocument().addDocumentListener(new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                String text = txtSearch.getText();
                if (text.trim().length() == 0) {
                    rowSorter.setRowFilter(null);
                } else {
                    rowSorter.setRowFilter(RowFilter.regexFilter("(?i)" + text));
                }
            }

            @Override
            public void removeUpdate(DocumentEvent e) {
                String text = txtSearch.getText();
                if (text.trim().length() == 0) {
                    rowSorter.setRowFilter(null);
                } else {
                    rowSorter.setRowFilter(RowFilter.regexFilter("(?i)" + text));
                }
            }

            @Override
            public void changedUpdate(DocumentEvent e) {
            }
        });

        table.addMouseMotionListener(new MouseAdapter() {
            @Override
            public void mouseMoved(MouseEvent e) {
                JTable tbl = (JTable) e.getSource();
                AlignRenderer.currentRow = tbl.rowAtPoint(e.getPoint());
                CurrencyRenderer.currentRow = tbl.rowAtPoint(e.getPoint());
                PhoneNumberRendenrer.currentRow = tbl.rowAtPoint(e.getPoint());
                tbl.repaint();
            }

        });

        table.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (e.getClickCount() == 2 && table.getSelectedRow() != -1) {
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);

                    NhaCungCapObj nhaCungCapObj = new NhaCungCapObj();
                    nhaCungCapObj.setMaNCC((int) model.getValueAt(selectedRowIndex, 1));
                    nhaCungCapObj.setTenNCC(model.getValueAt(selectedRowIndex, 2).toString());
                    nhaCungCapObj.setDiaChi(model.getValueAt(selectedRowIndex, 3).toString());
                    nhaCungCapObj.setSdt(model.getValueAt(selectedRowIndex, 4).toString());
                    nhaCungCapObj.setSoNo((int) model.getValueAt(selectedRowIndex, 5));
                    nhaCungCapObj.setGhiChu(model.getValueAt(selectedRowIndex, 6).toString());

                    if (nhaCungCapJFameSua != null) {
                        nhaCungCapJFameSua.dispose();
                        nhaCungCapJFameSua = new NhaCungCapJFame(nhaCungCapObj, NhaCungCapJPanel.it);
                        nhaCungCapJFameSua.setTitle("Thông tin nhà cung cấp");
                        nhaCungCapJFameSua.setResizable(false);
                        nhaCungCapJFameSua.setVisible(true);
                        nhaCungCapJFameSua.setLocationRelativeTo(null);
                    } else {
                        nhaCungCapJFameSua = new NhaCungCapJFame(nhaCungCapObj, NhaCungCapJPanel.it);
                        nhaCungCapJFameSua.setTitle("Thông tin nhà cung cấp");
                        nhaCungCapJFameSua.setResizable(false);
                        nhaCungCapJFameSua.setVisible(true);
                        nhaCungCapJFameSua.setLocationRelativeTo(null);
                    }

                }
                
                if (SwingUtilities.isRightMouseButton(e) && table.getSelectedRow() != -1){
                    int dialogResult = JOptionPane.showConfirmDialog (null, "Bạn có muốn xóa không ","Warning",JOptionPane.YES_NO_OPTION);
                    if(dialogResult ==0){
                    
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);
                    
                    int MaNV = (int) model.getValueAt(selectedRowIndex, 1);
                    nhaCungCapService.Delete(MaNV);
                    setDateToTable();
                    } 
                }
            }

        });

        for (int i = 0; i < 7; i++) {
            switch (i) {
                case 4:
                    table.getColumnModel().getColumn(i).setCellRenderer(phoneNumberRendenrer);
                    break;
                case 5:
                    table.getColumnModel().getColumn(i).setCellRenderer(currencyRenderer);
                    break;
                default:
                    table.getColumnModel().getColumn(i).setCellRenderer(alignRenderer);
                    break;
            }
        }

        table.getColumnModel().getColumn(0).setMinWidth(60);
        table.getColumnModel().getColumn(0).setMaxWidth(30);
        table.getColumnModel().getColumn(0).setPreferredWidth(60);

        table.getColumnModel().getColumn(1).setMinWidth(0);
        table.getColumnModel().getColumn(1).setMaxWidth(0);
        table.getColumnModel().getColumn(1).setPreferredWidth(0);

        table.getTableHeader().setBackground(new Color(102, 255, 255));
        table.getTableHeader().setFont(new Font("Arial", Font.BOLD, 18));
        table.getTableHeader().setPreferredSize(new Dimension(100, 50));
        table.setRowHeight(50);
        table.validate();
        table.repaint();

        JScrollPane scrollPane = new JScrollPane();
        scrollPane.getViewport().add(table);
        scrollPane.setPreferredSize(new Dimension(1300, 400));

        pnView.removeAll();
        pnView.setLayout(new BorderLayout());
        pnView.add(scrollPane);
        pnView.validate();
        pnView.repaint();
    }

    public void setEvent() {
        btnAdd.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (nhaCungCapJFameThem != null) {
                    nhaCungCapJFameThem.dispose();
                    nhaCungCapJFameThem = new NhaCungCapJFame(new NhaCungCapObj(), NhaCungCapJPanel.it);
                    nhaCungCapJFameThem.setTitle("Thông tin nhà cung cấp");
                    nhaCungCapJFameThem.setResizable(false);
                    nhaCungCapJFameThem.setVisible(true);
                    nhaCungCapJFameThem.setLocationRelativeTo(null);
                } else {
                    nhaCungCapJFameThem = new NhaCungCapJFame(new NhaCungCapObj(), NhaCungCapJPanel.it);
                    nhaCungCapJFameThem.setTitle("Thông tin nhà cung cấp");
                    nhaCungCapJFameThem.setResizable(false);
                    nhaCungCapJFameThem.setVisible(true);
                    nhaCungCapJFameThem.setLocationRelativeTo(null);
                }

            }

            @Override
            public void mouseEntered(MouseEvent e) {

                btnAdd.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnAdd.setBackground(new Color(0, 153, 0));
            }

        });
    }
}
