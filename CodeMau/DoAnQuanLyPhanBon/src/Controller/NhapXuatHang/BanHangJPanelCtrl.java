package Controller.NhapXuatHang;

import Object.TaiKhoanObj;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JButton;
import view.Menu.NhapXuatHang.LoadKhachHangJFame;
import Object.KhachHangObj;
import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import view.Menu.BanHangJPanel;
import view.Menu.NhapXuatHang.LoadHangHoaBanHangJFame;
import listNhapXuat.BanHangList;
import Model.BanHangModCtrl;
import Object.CTHDBanHangObj;
import Object.HangHoaObj;
import Object.HoaDonBanHangObj;
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
import java.text.DateFormat;
import java.text.ParseException;
import javax.swing.JFrame;
import view.Menu.NhapXuatHang.HoaDonBanHangJFame;

public class BanHangJPanelCtrl {

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
    private JLabel lblMaKH;
    
   // private int MaKH = 0;
    private int TSL;
    private int TTH;
    private float TTT;
    private DecimalFormat format = new DecimalFormat("0");

    private JFrame loadKhachHangJFame;
    private JFrame loadHangHoaJFame;
    private JFrame hoaDonBanHangJFame;

    private HangHoaService hangHoaService = null;

    private BanHangService banHangService = null;

    public TableCellRenderer centerAlight = new AlignRenderer();

    public BanHangJPanelCtrl(JLabel lblTenNV, JLabel lblNgay, JButton btnKhachHang, JButton btnAdd, JLabel lblDiaChi, JLabel lblSDT, JLabel lblSoNo, JLabel lblGhiChu, JPanel pnTable, JButton btnNew, JButton btnThanhToan, JLabel lblTongTenHang, JLabel lblTongSL, JLabel lblTongCong, JLabel lblMaNV,JLabel lblMaKH) {
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
        this.lblMaKH = lblMaKH;

        this.hangHoaService = new HangHoaServiceImpl();
        this.banHangService = new BanHangServiceImpl();
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
                if (loadKhachHangJFame != null) {
                    loadKhachHangJFame.dispose();
                    loadKhachHangJFame = new LoadKhachHangJFame(BanHangJPanel.it);
                    loadKhachHangJFame.setTitle("Khách hàng");
                    loadKhachHangJFame.setResizable(false);
                    loadKhachHangJFame.setVisible(true);
                    loadKhachHangJFame.setLocationRelativeTo(null);
                } else {
                    loadKhachHangJFame = new LoadKhachHangJFame(BanHangJPanel.it);
                    loadKhachHangJFame.setTitle("Khách hàng");
                    loadKhachHangJFame.setResizable(false);
                    loadKhachHangJFame.setVisible(true);
                    loadKhachHangJFame.setLocationRelativeTo(null);
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
                    loadHangHoaJFame = new LoadHangHoaBanHangJFame(BanHangJPanel.it);
                    loadHangHoaJFame.setTitle("Thêm hàng hóa");
                    loadHangHoaJFame.setResizable(false);
                    loadHangHoaJFame.setVisible(true);
                    loadHangHoaJFame.setLocationRelativeTo(null);
                } else {
                    loadHangHoaJFame = new LoadHangHoaBanHangJFame(BanHangJPanel.it);
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
                int kt = 0;
                for (int i = 0; i < listSL.size(); i++) {
                    if (hangHoaService.checkSL(listSL.get(i).getMaHH(), listSL.get(i).getSl())) {
                        kt = kt + 1;
                    } else {
                        JOptionPane.showMessageDialog(null, listSL.get(i).getTeHH() + " không đủ số lượng trong kho!");
                    }

                }
                if (kt == listSL.size()) {
                    int MaHDB = banHangService.setMaHD() + 1;
                    List<CTHDBanHangObj> listCTHDB = new ArrayList<CTHDBanHangObj>();

                    for (int row = 0; row < table.getRowCount(); row++) {
                        CTHDBanHangObj CTHDObj = new CTHDBanHangObj();
                        CTHDObj.setMaHDBH(MaHDB);
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

                    HoaDonBanHangObj hdbhObj = new HoaDonBanHangObj();
                    hdbhObj.setMaHDBH(MaHDB);
                    hdbhObj.setKhachHang(Integer.parseInt(lblMaKH.getText()));
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
                        hoaDonBanHangJFame = new HoaDonBanHangJFame(BanHangJPanel.it, listCTHDB, hdbhObj, TenKhachHang, TongTien);
                        hoaDonBanHangJFame.setTitle("Thanh toán");
                        hoaDonBanHangJFame.setResizable(false);
                        hoaDonBanHangJFame.setVisible(true);
                        hoaDonBanHangJFame.setLocationRelativeTo(null);
                    } else {
                        hoaDonBanHangJFame = new HoaDonBanHangJFame(BanHangJPanel.it, listCTHDB, hdbhObj, TenKhachHang, TongTien);
                        hoaDonBanHangJFame.setTitle("Thanh toán");
                        hoaDonBanHangJFame.setResizable(false);
                        hoaDonBanHangJFame.setVisible(true);
                        hoaDonBanHangJFame.setLocationRelativeTo(null);
                    }

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

    public void loadKhachHang(KhachHangObj khachHangObj) {
        if (khachHangObj != null) {
            btnKhachHang.setText(khachHangObj.getTenKH());
            lblMaKH.setText(String.valueOf((int) khachHangObj.getMaKH()));
            lblDiaChi.setText(khachHangObj.getDiaChi());
            lblSDT.setText(khachHangObj.getSdt());
            lblSoNo.setText(String.valueOf((int) khachHangObj.getSoNo()));
            lblGhiChu.setText(khachHangObj.getGhiChu());
        } else {
            btnKhachHang.setText("");
            lblMaKH.setText("0");
            lblDiaChi.setText("");
            lblSDT.setText("");
            lblSoNo.setText("");
            lblGhiChu.setText("");
        }
    }

    public void setDateToTable() {
        BanHangList banHangList = new BanHangList();

        BanHangModCtrl model = new BanHangModCtrl(banHangList.getDesiredList(banHangList.getList()));

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

        // table.getColumnModel().getColumn(4).setCellRenderer(centerAlight);
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
                File file = new File("BanHang.TXT");
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

    public void setTong(){
        TSL = 0;
        TTH = 0;
        TTT = 0;
        BanHangList banHangList = new BanHangList();
        List<HangHoaObj> listTong = null;
        listTong = banHangList.getDesiredList(banHangList.getList());
        for(int i = 0 ; i< listTong.size() ; i++){
            TSL = TSL + listTong.get(i).getSl();
            TTT = TTT + (float)((listTong.get(i).getSl() * listTong.get(i).getGiaBan()) -((listTong.get(i).getSl() * listTong.get(i).getGiaBan() * listTong.get(i).getGiaMua() *0.01)));
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
        try (PrintWriter writer = new PrintWriter("BanHang.TXT")) {
            writer.print("");
            writer.close();
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

}
