package Controller.NhapXuatHang;

import Object.TaiKhoanObj;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JButton;
import Object.NhaCungCapObj;
import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import view.Menu.NhapHangJPanel;
import listNhapXuat.NhapHangList;
import Model.NhapHangModCtrl;
import Object.CTHDNhapHangObj;
import Object.HangHoaObj;
import Object.HoaDonNhapHangObj;
import RendenrerInJTable.AlignRenderer;
import Service.HangHoaService;
import Service.HangHoaServiceImpl;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;
import javax.swing.table.TableCellRenderer;
import Service.BanHangService;
import Service.BanHangServiceImpl;
import Service.NhapHangService;
import Service.NhapHangServiceImpl;
import java.text.DateFormat;
import java.text.ParseException;
import javax.swing.JFrame;
import view.Menu.NhapXuatHang.LoadNhaCungCapJFame;
import view.Menu.NhapXuatHang.LoadHangHoaNhapHangJFame;
import view.Menu.NhapXuatHang.HoaDonNhapHangJFame;

public class NhapHangJPanelCtrl {

    private JLabel lblTenNV;
    private JLabel lblNgay;
    private JButton btnKhachHang;
    private JButton btnAdd;
    private JLabel lblDiaChi;
    private JLabel lblSDT;
    private JLabel lblSoNo;
    private JLabel lblGhiChu;
    private JPanel pnTable;
    private JButton btnNew;
    private JButton btnThanhToan;
    private JLabel lblTongTenHang;
    private JLabel lblTongSL;
    private JLabel lblTongCong;
    private JTable table;
    private JLabel lblMaNV;
    private JLabel lblMaNCC;
    //private int MaKH = 0;
    private int TSL;
    private int TTH;
    private float TTT;
    private DecimalFormat format = new DecimalFormat("0");

    private JFrame loadNhaCungCapJFame;
    private JFrame loadHangHoaJFame;
    private JFrame hoaDonBanHangJFame;

    private HangHoaService hangHoaService = null;

    private NhapHangService nhapHangService = null;

    public TableCellRenderer centerAlight = new AlignRenderer();

    public NhapHangJPanelCtrl(JLabel lblTenNV, JLabel lblNgay, JButton btnKhachHang, JButton btnAdd, JLabel lblDiaChi, JLabel lblSDT, JLabel lblSoNo, JLabel lblGhiChu, JPanel pnTable, JButton btnNew, JButton btnThanhToan, JLabel lblTongTenHang, JLabel lblTongSL, JLabel lblTongCong, JLabel lblMaNV, JLabel lblMaNCC) {
        this.lblTenNV = lblTenNV;
        this.lblNgay = lblNgay;
        this.btnKhachHang = btnKhachHang;
        this.btnAdd = btnAdd;
        this.lblDiaChi = lblDiaChi;
        this.lblSDT = lblSDT;
        this.lblSoNo = lblSoNo;
        this.lblGhiChu = lblGhiChu;
        this.pnTable = pnTable;
        this.btnNew = btnNew;
        this.btnThanhToan = btnThanhToan;
        this.lblTongTenHang = lblTongTenHang;
        this.lblTongSL = lblTongSL;
        this.lblTongCong = lblTongCong;
        this.lblMaNV = lblMaNV;
        this.lblMaNCC = lblMaNCC;

        this.hangHoaService = new HangHoaServiceImpl();
        this.nhapHangService = new NhapHangServiceImpl();
    }

    public void setView(TaiKhoanObj taiKhoanObj) {
        Date now = new Date();
        SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
        String strDate = formatter.format(now);
        lblNgay.setText(strDate);
        lblTenNV.setText(taiKhoanObj.getTenNV());
        lblMaNV.setText(String.valueOf(taiKhoanObj.getMaTK()));

    }

    public void setEvent() {
        btnKhachHang.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (loadNhaCungCapJFame != null) {
                    loadNhaCungCapJFame.dispose();
                    loadNhaCungCapJFame = new LoadNhaCungCapJFame(NhapHangJPanel.it);
                    loadNhaCungCapJFame.setTitle("Nhà cung cấp");
                    loadNhaCungCapJFame.setResizable(false);
                    loadNhaCungCapJFame.setVisible(true);
                    loadNhaCungCapJFame.setLocationRelativeTo(null);
                } else {
                    loadNhaCungCapJFame = new LoadNhaCungCapJFame(NhapHangJPanel.it);
                    loadNhaCungCapJFame.setTitle("Nhà cung cấp");
                    loadNhaCungCapJFame.setResizable(false);
                    loadNhaCungCapJFame.setVisible(true);
                    loadNhaCungCapJFame.setLocationRelativeTo(null);
                }

            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnKhachHang.setBackground(new Color(102, 255, 207));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnKhachHang.setBackground(new Color(230, 255, 247));
            }

        });

        btnAdd.addMouseListener(new MouseAdapter() {

            @Override
            public void mouseClicked(MouseEvent e) {
                if (loadHangHoaJFame != null) {
                    loadHangHoaJFame.dispose();
                    loadHangHoaJFame = new LoadHangHoaNhapHangJFame(NhapHangJPanel.it);
                    loadHangHoaJFame.setTitle("Thêm hàng hóa");
                    loadHangHoaJFame.setResizable(false);
                    loadHangHoaJFame.setVisible(true);
                    loadHangHoaJFame.setLocationRelativeTo(null);
                } else {
                    loadHangHoaJFame = new LoadHangHoaNhapHangJFame(NhapHangJPanel.it);
                    loadHangHoaJFame.setTitle("Thêm hàng hóa");
                    loadHangHoaJFame.setResizable(false);
                    loadHangHoaJFame.setVisible(true);
                    loadHangHoaJFame.setLocationRelativeTo(null);
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

        btnNew.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                DeleteTxt();
                setDateToTable();
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnNew.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnNew.setBackground(new Color(0, 153, 0));
            }
        });

        btnThanhToan.addMouseListener(new MouseAdapter() {

            @Override
            public void mouseClicked(MouseEvent e) {

                setDateToTable();
                String tenHH = null;
                int SL = 0;
                int Mahh = 0;

                List<HangHoaObj> listSL = new ArrayList<HangHoaObj>();

                for (int row = 0; row < table.getRowCount(); row++) {
                    for (int column = 0; column < table.getColumnCount(); column++) {
                        switch (column) {
                            case 1:
                                Mahh = (int) table.getValueAt(row, column);
                                break;
                            case 2:
                                tenHH = String.valueOf(table.getValueAt(row, column));
                                break;
                            case 4:
                                SL = (int) table.getValueAt(row, column);
                                break;
                            default:
                                break;
                        }
                    }
                    HangHoaObj hhObj = new HangHoaObj(tenHH, SL, Mahh);
                    listSL.add(hhObj);
                }            
                if (btnKhachHang.getText() != null) {
                    int MaHDB = nhapHangService.setMaHD() + 1;
                    List<CTHDNhapHangObj> listCTHDB = new ArrayList<CTHDNhapHangObj>();

                    for (int row = 0; row < table.getRowCount(); row++) {
                        CTHDNhapHangObj CTHDObj = new CTHDNhapHangObj();
                        CTHDObj.setMaHDNH(MaHDB);
                        for (int column = 0; column < table.getColumnCount(); column++) {
                            switch (column) {
                                case 1:
                                    CTHDObj.setSanPham((int) table.getValueAt(row, column));
                                    break;
                                case 4:
                                    CTHDObj.setSl((int) table.getValueAt(row, column));
                                    break;
                                case 5:
                                    CTHDObj.setDonGia((float) table.getValueAt(row, column));
                                    break;
                                case 6:
                                    CTHDObj.setCk((float) table.getValueAt(row, column));
                                    break;
                                default:
                                    break;
                            }
                        }
                        listCTHDB.add(CTHDObj);

                    }

                    HoaDonNhapHangObj hdbhObj = new HoaDonNhapHangObj();
                    hdbhObj.setMaHDNH(MaHDB);
                    hdbhObj.setNcc(Integer.parseInt(lblMaNCC.getText()));
                    hdbhObj.setNhanVienLap(Integer.parseInt(lblMaNV.getText()));
                    DateFormat dateFormat = null;
                    dateFormat = new SimpleDateFormat("dd/MM/yyyy");
                    try {
                        hdbhObj.setNgayLap(dateFormat.parse(lblNgay.getText()));
                    } catch (ParseException ex) {
                        ex.printStackTrace();
                    }
                    hdbhObj.setTienTra(0);

                    String TenKhachHang = btnKhachHang.getText();

                    float TongTien = Float.parseFloat(lblTongCong.getText());
                    if (hoaDonBanHangJFame != null) {
                        hoaDonBanHangJFame.dispose();
                        hoaDonBanHangJFame = new HoaDonNhapHangJFame(NhapHangJPanel.it, listCTHDB, hdbhObj, TenKhachHang, TongTien);
                        hoaDonBanHangJFame.setTitle("Thanh toán");
                        hoaDonBanHangJFame.setResizable(false);
                        hoaDonBanHangJFame.setVisible(true);
                        hoaDonBanHangJFame.setLocationRelativeTo(null);
                    } else {
                        hoaDonBanHangJFame = new HoaDonNhapHangJFame(NhapHangJPanel.it, listCTHDB, hdbhObj, TenKhachHang, TongTien);
                        hoaDonBanHangJFame.setTitle("Thanh toán");
                        hoaDonBanHangJFame.setResizable(false);
                        hoaDonBanHangJFame.setVisible(true);
                        hoaDonBanHangJFame.setLocationRelativeTo(null);
                    }

                }else{
                    JOptionPane.showMessageDialog(null, "Chưa chọn nhà cung cấp");
                }

            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnThanhToan.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnThanhToan.setBackground(new Color(0, 153, 0));
            }
        });

    }

    public void loadKhachHang(NhaCungCapObj khachHangObj) {
        if (khachHangObj != null) {
            btnKhachHang.setText(khachHangObj.getTenNCC());
            lblMaNCC.setText(String.valueOf((int) khachHangObj.getMaNCC()));
            lblDiaChi.setText(khachHangObj.getDiaChi());
            lblSDT.setText(khachHangObj.getSdt());
            lblSoNo.setText(String.valueOf((int) khachHangObj.getSoNo()));
            lblGhiChu.setText(khachHangObj.getGhiChu());
        } else {
            btnKhachHang.setText("");
            lblMaNCC.setText("0");
            lblDiaChi.setText("");
            lblSDT.setText("");
            lblSoNo.setText("");
            lblGhiChu.setText("");
        }
    }

    public void setDateToTable() {
        NhapHangList banHangList = new NhapHangList();

        NhapHangModCtrl model = new NhapHangModCtrl(banHangList.getDesiredList(banHangList.getList()));

        JTable table = new JTable(model);

        table.addMouseListener(new MouseAdapter() {

            @Override
            public void mouseClicked(MouseEvent e) {

                int selectedRowIndex = table.getSelectedRow();

                if (e.getClickCount() == 1) {
                    DeleteTxt();
                    for (int row = 0; row < table.getRowCount(); row++) {
                        luuTam(table, row);
                        setTong();
                    }
                }

                if (SwingUtilities.isRightMouseButton(e) && e.getClickCount() == 1) {
                    DeleteTxt();
                    for (int row = 0; row < table.getRowCount(); row++) {
                        if (row != selectedRowIndex) {
                            luuTam(table, row);
                            setTong();
                        }
                    }

                    setDateToTable();

                }
            }

        });

        table.getColumnModel().getColumn(1).setMinWidth(0);
        table.getColumnModel().getColumn(1).setMaxWidth(0);
        table.getColumnModel().getColumn(1).setPreferredWidth(0);

        table.getColumnModel().getColumn(0).setMinWidth(60);
        table.getColumnModel().getColumn(0).setMaxWidth(60);
        table.getColumnModel().getColumn(0).setPreferredWidth(60);

        table.getColumnModel().getColumn(6).setMinWidth(80);
        table.getColumnModel().getColumn(6).setMaxWidth(80);
        table.getColumnModel().getColumn(6).setPreferredWidth(80);

        table.setFont(new Font("Arial", Font.PLAIN, 16));
        table.getTableHeader().setBackground(new Color(102, 255, 255));
        table.getTableHeader().setFont(new Font("Arial", Font.BOLD, 18));
        table.getTableHeader().setPreferredSize(new Dimension(100, 50));
        table.setRowHeight(50);
        table.validate();
        table.repaint();

        setTong();
        this.table = table;

        JScrollPane scrollPane = new JScrollPane();
        scrollPane.getViewport().add(table);
        scrollPane.setPreferredSize(new Dimension(1300, 400));

        pnTable.removeAll();
        pnTable.setLayout(new BorderLayout());
        pnTable.add(scrollPane);
        pnTable.validate();
        pnTable.repaint();

    }

    public void luuTam(JTable table, int row) {

        for (int column = 0; column < table.getColumnCount(); column++) {
            FileWriter fw = null;
            BufferedWriter bw = null;
            try {
                File file = new File("NhapHang.TXT");
                fw = new FileWriter(file.getName(), true);
                bw = new BufferedWriter(fw);

                switch (column) {
                    case 1:
                        bw.write((int) table.getValueAt(row, column) + "\n");
                        break;
                    case 2:
                        bw.write(table.getValueAt(row, column) + "\n");
                        break;
                    case 3:
                        bw.write(table.getValueAt(row, column) + "\n");
                        break;
                    case 4:
                        bw.write((int) table.getValueAt(row, column) + "\n");
                        break;
                    case 5:
                        bw.write((float) table.getValueAt(row, column) + "\n");
                        break;
                    case 6:
                        bw.write((float) table.getValueAt(row, column) + "\n");
                        break;
                    default:
                        break;
                }
            } catch (Exception ex) {
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
        }

    }

    public void setTong() {
        TSL = 0;
        TTH = 0;
        TTT = 0;
        NhapHangList banHangList = new NhapHangList();
        List<HangHoaObj> listTong = null;
        listTong = banHangList.getDesiredList(banHangList.getList());
        for (int i = 0; i < listTong.size(); i++) {
            TSL = TSL + listTong.get(i).getSl();
            TTT = TTT + (float) ((listTong.get(i).getSl() * listTong.get(i).getGiaBan()) - ((listTong.get(i).getSl() * listTong.get(i).getGiaBan() * listTong.get(i).getGiaMua() * 0.01)));
        }
        TTH = listTong.size();
        if (listTong.size() > 0) {
            lblTongTenHang.setText(String.valueOf(TTH));
            lblTongSL.setText(String.valueOf(TSL));
            lblTongCong.setText(String.valueOf(format.format(TTT + Float.parseFloat(lblSoNo.getText()))));
        } else {
            lblTongTenHang.setText("0");
            lblTongSL.setText("0");
            lblTongCong.setText("0");

        }
    }

    public void DeleteTxt() {
        try (PrintWriter writer = new PrintWriter("NhapHang.TXT")) {
            writer.print("");
            writer.close();
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
}
