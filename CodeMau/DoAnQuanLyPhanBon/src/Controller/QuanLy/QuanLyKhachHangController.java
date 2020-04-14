package Controller.QuanLy;

import Service.KhachHangService;
import Service.KhachHangServiceImpl;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;
import java.util.List;
import javax.swing.table.DefaultTableModel;
import Model.QuanLyKhachHangMod;
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
import view.Menu.QuanLyView.JFame.KhachHangJFame;
import Object.KhachHangObj;
import RendenrerInJTable.AlignRenderer;
import RendenrerInJTable.CurrencyRenderer;
import RendenrerInJTable.PhoneNumberRendenrer;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;
import javax.swing.table.TableCellRenderer;
import view.Menu.QuanLyView.KhachHangJPanel;

public class QuanLyKhachHangController {

    private JFrame khachHangJFameThem;
    private JFrame khachHangJFameSua;
    private JButton btnAdd;
    private JPanel pnView;
    private JTextField txtSearch;

    private KhachHangService khachHangService = null;

    private String[] listColumn = {"STT", "Mã KH", "Tên KH", "Địa chỉ", "SDT", "Số nợ", "Ghi chú"};

    private TableRowSorter<TableModel> rowSorter = null;

    public TableCellRenderer alignRenderer = new AlignRenderer();

    public TableCellRenderer currencyRenderer = new CurrencyRenderer();

    public TableCellRenderer phoneNumberRendenrer = new PhoneNumberRendenrer();

    public QuanLyKhachHangController(JButton btnAdd, JPanel pnView, JTextField txtSearch) {
        this.btnAdd = btnAdd;
        this.pnView = pnView;
        this.txtSearch = txtSearch;

        this.khachHangService = new KhachHangServiceImpl();
    }

    public void setDateToTable() {
        List<KhachHangObj> listItem = khachHangService.getList();

        DefaultTableModel model = new QuanLyKhachHangMod().setTableKhachHang(listItem, listColumn);
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

                    KhachHangObj khachHangObj = new KhachHangObj();
                    khachHangObj.setMaKH((int) model.getValueAt(selectedRowIndex, 1));
                    khachHangObj.setTenKH(model.getValueAt(selectedRowIndex, 2).toString());
                    khachHangObj.setDiaChi(model.getValueAt(selectedRowIndex, 3).toString());
                    khachHangObj.setSdt(model.getValueAt(selectedRowIndex, 4).toString());
                    khachHangObj.setSoNo((int) model.getValueAt(selectedRowIndex, 5));
                    khachHangObj.setGhiChu(model.getValueAt(selectedRowIndex, 6).toString());

                    if (khachHangJFameSua != null) {
                        khachHangJFameSua.dispose();
                        khachHangJFameSua = new KhachHangJFame(khachHangObj, KhachHangJPanel.it);
                        khachHangJFameSua.setTitle("Thông tin khách hàng");
                        khachHangJFameSua.setResizable(false);
                        khachHangJFameSua.setVisible(true);
                        khachHangJFameSua.setLocationRelativeTo(null);
                    } else {

                        khachHangJFameSua = new KhachHangJFame(khachHangObj, KhachHangJPanel.it);
                        khachHangJFameSua.setTitle("Thông tin khách hàng");
                        khachHangJFameSua.setResizable(false);
                        khachHangJFameSua.setVisible(true);
                        khachHangJFameSua.setLocationRelativeTo(null);
                    }
                }
                
                  if (SwingUtilities.isRightMouseButton(e) && table.getSelectedRow() != -1){
                      int dialogResult = JOptionPane.showConfirmDialog (null, "Bạn có muốn xóa không ","Warning",JOptionPane.YES_NO_OPTION);
                    if(dialogResult ==0){
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);
                    
                    int MaNV = (int) model.getValueAt(selectedRowIndex, 1);
                    khachHangService.Delete(MaNV);
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
                if (khachHangJFameThem != null) {
                    khachHangJFameThem.dispose();
                    khachHangJFameThem = new KhachHangJFame(new KhachHangObj(), KhachHangJPanel.it);
                    khachHangJFameThem.setTitle("Thông tin Khách hàng");
                    khachHangJFameThem.setResizable(false);
                    khachHangJFameThem.setVisible(true);
                    khachHangJFameThem.setLocationRelativeTo(null);
                } else {
                    khachHangJFameThem = new KhachHangJFame(new KhachHangObj(), KhachHangJPanel.it);
                    khachHangJFameThem.setTitle("Thông tin Khách hàng");
                    khachHangJFameThem.setResizable(false);
                    khachHangJFameThem.setVisible(true);
                    khachHangJFameThem.setLocationRelativeTo(null);
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
