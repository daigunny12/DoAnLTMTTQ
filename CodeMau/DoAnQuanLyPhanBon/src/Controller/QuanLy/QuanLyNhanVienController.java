package Controller.QuanLy;

import Service.NhanVienService;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;
import java.util.List;
import Object.NhanVienObj;
import Service.NhanVienServiceImpl;
import Model.QuanLyNhanVienMod;
import RendenrerInJTable.AlignRenderer;
import RendenrerInJTable.PhoneNumberRendenrer;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.RowFilter;
import javax.swing.SwingUtilities;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableCellRenderer;
import view.Menu.QuanLyView.JFame.NhanVienJFrame;
import view.Menu.QuanLyView.NhanVienJPanel;

public class QuanLyNhanVienController {

    private JFrame nhanVienJFrameThem;
    private JFrame nhanVienJFrameSua;
    private JPanel pnView;
    private JButton btnAdd;
    private JTextField txtSearch;

    private NhanVienService nhanVienService = null;

    private String[] listColumn = {"Mã NV", "STT", "Tên NV", "Giới tính", "Ngày sinh", "Địa chỉ", "SDT", "Ghi chú"};

    private TableRowSorter<TableModel> rowSorter = null;

    public TableCellRenderer alignRenderer = new AlignRenderer();

    public TableCellRenderer phoneNumberRendenrer = new PhoneNumberRendenrer();

    public QuanLyNhanVienController(JPanel pnView, JButton btnAdd, JTextField txtSearch) {
        this.pnView = pnView;
        this.btnAdd = btnAdd;
        this.txtSearch = txtSearch;
        this.nhanVienService = new NhanVienServiceImpl();
    }

    public void setDateToTable() {
        List<NhanVienObj> listItem = nhanVienService.getList();

        DefaultTableModel model = new QuanLyNhanVienMod().setTableNhanVien(listItem, listColumn);
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

                    NhanVienObj nhanVienObj = new NhanVienObj();
                    nhanVienObj.setMaNV((int) model.getValueAt(selectedRowIndex, 0));
                    nhanVienObj.setTenNV(model.getValueAt(selectedRowIndex, 2).toString() + "");
                    nhanVienObj.setGioiTinh(model.getValueAt(selectedRowIndex, 3).toString());
                    String stringDate = model.getValueAt(selectedRowIndex, 4).toString();
                    
                    DateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy");
                    try {
                        nhanVienObj.setNgaySinh(dateFormat.parse(stringDate));
                    } catch (ParseException ex) {
                        ex.printStackTrace();
                    }
                    nhanVienObj.setDiaChi(model.getValueAt(selectedRowIndex, 5).toString() + "");
                    nhanVienObj.setSdt(model.getValueAt(selectedRowIndex, 6).toString() + "");
                    nhanVienObj.setGhiChu(model.getValueAt(selectedRowIndex, 7).toString() + "");

                    if (nhanVienJFrameSua != null) {
                        nhanVienJFrameSua.dispose();
                        nhanVienJFrameSua = new NhanVienJFrame(nhanVienObj, NhanVienJPanel.it);
                        nhanVienJFrameSua.setTitle(" Sửa thông tin nhân viên");
                        nhanVienJFrameSua.setResizable(false);
                        nhanVienJFrameSua.setVisible(true);
                        nhanVienJFrameSua.setLocationRelativeTo(null);
                    } else {
                        nhanVienJFrameSua = new NhanVienJFrame(nhanVienObj, NhanVienJPanel.it);
                        nhanVienJFrameSua.setTitle(" Sửa thông tin nhân viên");
                        nhanVienJFrameSua.setResizable(false);
                        nhanVienJFrameSua.setVisible(true);
                        nhanVienJFrameSua.setLocationRelativeTo(null);
                    }

                }
                
                
                if (SwingUtilities.isRightMouseButton(e) && table.getSelectedRow() != -1){
                    
                    int dialogResult = JOptionPane.showConfirmDialog (null, "Bạn có muốn xóa không ","Warning",JOptionPane.YES_NO_OPTION);
                    if(dialogResult ==0){
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);
                    
                    int MaNV = (int) model.getValueAt(selectedRowIndex, 0);
                    nhanVienService.DeleteNV(MaNV);
                    setDateToTable();
                    }
                }
            }

        });

        for (int i = 0; i < 8; i++) {
            if (i != 6) {
                table.getColumnModel().getColumn(i).setCellRenderer(alignRenderer);
            } else {
                table.getColumnModel().getColumn(i).setCellRenderer(phoneNumberRendenrer);
            }
        }

        table.getColumnModel().getColumn(0).setMinWidth(0);
        table.getColumnModel().getColumn(0).setMaxWidth(0);
        table.getColumnModel().getColumn(0).setPreferredWidth(0);

        table.getColumnModel().getColumn(1).setMinWidth(60);
        table.getColumnModel().getColumn(1).setMaxWidth(30);
        table.getColumnModel().getColumn(1).setPreferredWidth(60);

        table.getColumnModel().getColumn(3).setMinWidth(100);
        table.getColumnModel().getColumn(3).setMaxWidth(100);
        table.getColumnModel().getColumn(3).setPreferredWidth(100);

        table.getColumnModel().getColumn(6).setMinWidth(120);
        table.getColumnModel().getColumn(6).setMaxWidth(60);
        table.getColumnModel().getColumn(6).setPreferredWidth(120);

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
                if (nhanVienJFrameThem != null) {
                    nhanVienJFrameThem.dispose();
                    nhanVienJFrameThem = new NhanVienJFrame(new NhanVienObj(), NhanVienJPanel.it);
                    nhanVienJFrameThem.setTitle("Thêm nhân viên");
                    nhanVienJFrameThem.setResizable(false);
                    nhanVienJFrameThem.setVisible(true);
                    nhanVienJFrameThem.setLocationRelativeTo(null);
                } else {
                    nhanVienJFrameThem = new NhanVienJFrame(new NhanVienObj(), NhanVienJPanel.it);
                    nhanVienJFrameThem.setTitle("Thêm nhân viên");
                    nhanVienJFrameThem.setResizable(false);
                    nhanVienJFrameThem.setVisible(true);
                    nhanVienJFrameThem.setLocationRelativeTo(null);
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
