package Controller.NhapXuatHang;

import Model.QuanLyKhachHangMod;
import Object.KhachHangObj;
import Service.KhachHangService;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;
import Service.KhachHangServiceImpl;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.List;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.RowFilter;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.table.DefaultTableModel;
import view.Menu.BanHangJPanel;

public class LoadKhachHangJFameCtrl {

    private JButton btnOK;
    private JPanel pnView;
    private JTextField txtSearch;
    private JFrame frame;

    public KhachHangObj KHObj = null;

    public KhachHangService khachHangService = null;

    private String[] listColumn = {"STT", "Mã KH", "Tên KH", "Địa chỉ", "SDT", "Số nợ", "Ghi chú"};

    private TableRowSorter<TableModel> rowSorter = null;

    public LoadKhachHangJFameCtrl(JButton btnOK, JPanel pnView, JTextField txtSearch, JFrame frame) {
        this.btnOK = btnOK;
        this.pnView = pnView;
        this.txtSearch = txtSearch;
        this.frame = frame;

        this.khachHangService = new KhachHangServiceImpl();
    }

    public void setDateToTable() {
        List<KhachHangObj> listItem = khachHangService.getList();

        DefaultTableModel model = new QuanLyKhachHangMod().setTableKhachHang(listItem, listColumn);
        JTable table = new JTable(model);

        rowSorter = new TableRowSorter<>(table.getModel());
        table.setRowSorter(rowSorter);

        btnOK.setEnabled(false);

        table.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {

                btnOK.setEnabled(true);

                int selectedRowIndex = table.getSelectedRow();
                selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);

                DefaultTableModel model = (DefaultTableModel) table.getModel();

                KhachHangObj khachHangObj = new KhachHangObj();

                khachHangObj.setMaKH((int) model.getValueAt(selectedRowIndex, 1));
                khachHangObj.setTenKH(model.getValueAt(selectedRowIndex, 2).toString());
                khachHangObj.setDiaChi(model.getValueAt(selectedRowIndex, 3).toString());
                khachHangObj.setSdt(model.getValueAt(selectedRowIndex, 4).toString());
                khachHangObj.setSoNo((int) model.getValueAt(selectedRowIndex, 5));
                khachHangObj.setGhiChu(model.getValueAt(selectedRowIndex, 6).toString());
                KHObj = khachHangObj;
            }
        });

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

        table.getColumnModel().getColumn(0).setMinWidth(60);
        table.getColumnModel().getColumn(0).setMaxWidth(30);
        table.getColumnModel().getColumn(0).setPreferredWidth(60);

        table.getColumnModel().getColumn(1).setMinWidth(0);
        table.getColumnModel().getColumn(1).setMaxWidth(0);
        table.getColumnModel().getColumn(1).setPreferredWidth(0);

        table.setFont(new Font("Arial", Font.PLAIN, 16));
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

    public void setEvnt(BanHangJPanel banHangJPanel) {
        btnOK.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
              if (KHObj != null) {
                    banHangJPanel.LoadKhachHang(KHObj);
                    frame.dispose();
                }
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnOK.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnOK.setBackground(new Color(0,153,0));
            }
           
            
            
        });
    }
}
