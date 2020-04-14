package Controller.NhapXuatHang;

import Model.QuanLyHangHoaMod;
import Object.HangHoaObj;
import Service.HangHoaService;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.util.List;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.RowFilter;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;
import Service.HangHoaServiceImpl;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import javax.swing.JLabel;
import view.Menu.NhapHangJPanel;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.text.DecimalFormat;

public class LoadHangHoaNhapHangJFameCtrl {

    private JPanel pnTable;
    private JButton btnAdd;
    private JTextField txtSearch;
    private JTextField txtSL;
    private JTextField txtGiaMua;
    private JLabel lblDVT;
    private JTextField txtCK;
    private JTextField txtThanhTien;
    private JLabel lblThongBao;

    private DecimalFormat format = new DecimalFormat("0");

    private HangHoaService hangHoaService = null;

    private String[] listColumn = {"STT", "Mã sp", "Tên sản phẩm", "Đơn vị tính", "Giá bán", "Giá mua", "SL", "Ghi chú"};

    private TableRowSorter<TableModel> rowSorter = null;

    private ArrayList<HangHoaObj> list = null;

    private int MaHH;

    private int SL;

    private int SLCL;

    private float gia;

    private float CK;

    private String tenHH;

    private float thanhTien;

    public LoadHangHoaNhapHangJFameCtrl(JPanel pnTable, JButton btnAdd, JTextField txtSearch, JTextField txtSL, JTextField txtGiaMua, JLabel lblDVT, JTextField txtCK, JTextField txtThanhTien, JLabel lblThongBao) {
        this.pnTable = pnTable;
        this.btnAdd = btnAdd;
        this.txtSearch = txtSearch;
        this.txtSL = txtSL;
        this.txtGiaMua = txtGiaMua;
        this.lblDVT = lblDVT;
        this.txtCK = txtCK;
        this.txtThanhTien = txtThanhTien;
        this.lblThongBao = lblThongBao;

        this.hangHoaService = new HangHoaServiceImpl();
    }

    public void TinhTien() {
        SL = Integer.parseInt(txtSL.getText());
        gia = Float.parseFloat(txtGiaMua.getText());
        CK = (float) (Float.parseFloat(txtCK.getText()) * 0.01);
        thanhTien = (SL * gia) - (CK * SL * gia);
        txtThanhTien.setText(String.valueOf(format.format(thanhTien)));
    }

    public void KeyTXT(JTextField txt, KeyEvent e) {
        char c = e.getKeyChar();
        if (c >= '0' && c <= '9') {
            txt.setEditable(true);
        } else {
            if (e.getExtendedKeyCode() == KeyEvent.VK_BACK_SPACE || e.getExtendedKeyCode() == KeyEvent.VK_DELETE) {
                txt.setEditable(true);
            } else {
                txt.setEditable(false);
            }
        }
    }

    public void setDateToTable() {

        List<HangHoaObj> listItem = hangHoaService.getList();

        DefaultTableModel model = new QuanLyHangHoaMod().setTableHangHoa(listItem, listColumn);
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

        table.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                int selectedRowIndex = table.getSelectedRow();
                selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);

                lblThongBao.setText("...");
                lblThongBao.setForeground(Color.black);

                DefaultTableModel model = (DefaultTableModel) table.getModel();
                lblDVT.setText(model.getValueAt(selectedRowIndex, 3).toString());
                txtGiaMua.setText(model.getValueAt(selectedRowIndex, 4).toString());
                MaHH = Integer.parseInt(model.getValueAt(selectedRowIndex, 1).toString());
                tenHH = model.getValueAt(selectedRowIndex, 2).toString();
                SLCL = Integer.parseInt(model.getValueAt(selectedRowIndex, 6).toString());
                txtSL.setText("1");
                txtCK.setText("0");
                txtThanhTien.setText(txtGiaMua.getText());
            }
        });

        txtSL.addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                char c = e.getKeyChar();
                if (c >= '0' && c <= '9') {
                    if (txtSL.getText().length() <= 10) {
                        if (txtSL.getText().length() != 0) {
                            lblThongBao.setText("...");
                            lblThongBao.setForeground(Color.BLACK);
                        }
                    } else {
                        lblThongBao.setText("Mua chi nhiều z");
                        lblThongBao.setForeground(Color.red);
                    }
                } else {
                    if (e.getExtendedKeyCode() == KeyEvent.VK_BACK_SPACE || e.getExtendedKeyCode() == KeyEvent.VK_DELETE) {
                        txtSL.setEditable(true);
                    } else {
                        txtSL.setEditable(false);
                    }
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                if (txtCK.getText().length() != 0) {
                    if (txtGiaMua.getText().length() != 0) {
                        if (txtSL.getText().length() != 0) {
                            if (Integer.parseInt(txtSL.getText()) != 0) {
                                lblThongBao.setText("...");
                                lblThongBao.setForeground(Color.black);
                                TinhTien();

                            } else {
                                txtThanhTien.setText("0");
                                lblThongBao.setText("Số lượng không thể bằng 0");
                                lblThongBao.setForeground(Color.red);
                            }
                            if (Integer.parseInt(txtSL.getText()) >= SLCL) {
                                txtSL.setEditable(false);
                                lblThongBao.setText("Số lượng vượt quá Số lượng kho");
                                lblThongBao.setForeground(Color.red);
                            }
                        } else {
                            txtThanhTien.setText("0");
                            lblThongBao.setText("Số lượng không thể trống");
                            lblThongBao.setForeground(Color.red);
                        }
                    } else {
                        lblThongBao.setText("Đơn giá trống");
                        lblThongBao.setForeground(Color.red);
                    }
                } else {
                    lblThongBao.setText("Chiết khấu trống");
                    lblThongBao.setForeground(Color.red);
                }
            }
        });

        txtCK.addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                char c = e.getKeyChar();
                if (c >= '0' && c <= '9') {
                    if (txtCK.getText().length() != 0) {
                        if (Float.parseFloat(txtCK.getText()) == 100 || txtCK.getText().length() < 2) {
                            txtCK.setEditable(true);
                            lblThongBao.setText("...");
                            lblThongBao.setForeground(Color.BLACK);
                        } else {
                            txtCK.setEditable(false);
                            lblThongBao.setText("Chiết khấu không quá 100%");
                            lblThongBao.setForeground(Color.red);
                        }
                    }
                } else {
                    if (e.getExtendedKeyCode() == KeyEvent.VK_BACK_SPACE || e.getExtendedKeyCode() == KeyEvent.VK_DELETE || e.getExtendedKeyCode() == KeyEvent.VK_PERIOD) {
                        txtCK.setEditable(true);
                    } else {
                        txtCK.setEditable(false);
                    }
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {

                if (txtSL.getText().length() != 0) {
                    if (txtGiaMua.getText().length() != 0) {
                        if (txtCK.getText().length() != 0) {
                            lblThongBao.setText("...");
                            lblThongBao.setForeground(Color.black);
                            TinhTien();
                        } else {
                            lblThongBao.setText("Chiết khấu trống");
                            lblThongBao.setForeground(Color.red);
                            gia = Float.parseFloat(txtGiaMua.getText());
                            SL = Integer.parseInt(txtSL.getText());
                            txtThanhTien.setText((String.valueOf(format.format(gia * SL))));
                        }
                    } else {
                        lblThongBao.setText("Đơn giá trống");
                        lblThongBao.setForeground(Color.red);
                    }
                } else {
                    lblThongBao.setText("Số lượng trống");
                    lblThongBao.setForeground(Color.red);
                }
            }

        });

        txtGiaMua.addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                KeyTXT(txtGiaMua, e);
            }

            @Override
            public void keyReleased(KeyEvent e) {
                if (txtCK.getText().length() != 0) {
                    if (txtSL.getText().length() != 0) {
                        if (txtGiaMua.getText().length() != 0) {
                            if (Float.parseFloat(txtGiaMua.getText()) != 0) {
                                lblThongBao.setText("...");
                                lblThongBao.setForeground(Color.black);
                                TinhTien();
                            } else {
                                txtThanhTien.setText("0");
                                lblThongBao.setText("Đơn giá không thể bằng 0");
                                lblThongBao.setForeground(Color.red);
                            }
                        } else {
                            txtThanhTien.setText("0");
                            lblThongBao.setText("Đơn giá không được trống");
                            lblThongBao.setForeground(Color.red);
                        }
                    } else {
                        lblThongBao.setText("Số lượng trống");
                        lblThongBao.setForeground(Color.red);
                    }
                } else {
                    lblThongBao.setText("Chiết khấu trống");
                    lblThongBao.setForeground(Color.red);
                }
            }
        });

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

        pnTable.removeAll();
        pnTable.setLayout(new BorderLayout());
        pnTable.add(scrollPane);
        pnTable.validate();
        pnTable.repaint();
    }

    public void setEvent(NhapHangJPanel nhapHangJPanel) {
        btnAdd.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (lblThongBao.getText().equals("...")) {
                    FileWriter fw = null;
                    BufferedWriter bw = null;
                    try {
                        File file = new File("NhapHang.TXT");
                        fw = new FileWriter(file.getName(), true);
                        bw = new BufferedWriter(fw);

                        bw.write(MaHH + "\n");
                        bw.write(tenHH + "\n");
                        bw.write(lblDVT.getText() + "\n");
                        bw.write(txtSL.getText() + "\n");
                        bw.write(txtGiaMua.getText() + "\n");
                        bw.write(txtCK.getText() + "\n");

                    } catch (IOException ex) {
                        ex.printStackTrace();
                    } finally {
                        try {
                            if (bw != null) {
                                bw.close();
                            }
                            if (fw != null) {
                                fw.close();
                            }
                        } catch (IOException ex) {
                            ex.printStackTrace();
                        }
                    }
                    nhapHangJPanel.setDateToTable();
                }
            }

            @Override
            public void mouseExited(MouseEvent e) {

            }

            @Override
            public void mouseEntered(MouseEvent e) {

            }

        });

    }
}
