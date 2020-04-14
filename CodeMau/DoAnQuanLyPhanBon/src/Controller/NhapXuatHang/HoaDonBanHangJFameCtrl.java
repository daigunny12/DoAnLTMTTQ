package Controller.NhapXuatHang;

import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JTextField;
import Object.HoaDonBanHangObj;
import Object.CTHDBanHangObj;
import Object.KhachHangObj;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.text.DecimalFormat;
import Service.BanHangService;
import Service.BanHangServiceImpl;
import Service.HangHoaService;
import Service.HangHoaServiceImpl;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.PrintWriter;
import java.util.List;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import view.Menu.BanHangJPanel;

public class HoaDonBanHangJFameCtrl {

    private JLabel lblKhachHang;
    private JTextField txtTongThanhToan;
    private JTextField txtKhachTra;
    private JTextField txtConLai;
    private JButton btnLuuVaIn;
    private JButton btnLuuKhongIn;
    private JButton btnHuy;
    private JFrame frame;
    private DecimalFormat format = new DecimalFormat("0");
    private BanHangService banHangService = null;
    private HangHoaService hangHoaService = null;

    public HoaDonBanHangJFameCtrl(JLabel lblKhachHang, JTextField txtTongThanhToan, JTextField txtKhachTra, JTextField txtConLai, JButton btnLuuVaIn, JButton btnLuuKhongIn, JButton btnHuy, JFrame frame) {
        this.lblKhachHang = lblKhachHang;
        this.txtTongThanhToan = txtTongThanhToan;
        this.txtKhachTra = txtKhachTra;
        this.txtConLai = txtConLai;
        this.btnLuuVaIn = btnLuuVaIn;
        this.btnLuuKhongIn = btnLuuKhongIn;
        this.btnHuy = btnHuy;
        this.frame = frame;
        this.banHangService = new BanHangServiceImpl();
        this.hangHoaService = new HangHoaServiceImpl();
    }

    public void setLoad(String khachHang, float Tong) {
        if (khachHang.length() != 0) {
            lblKhachHang.setText(khachHang);
        } else {
            lblKhachHang.setText("Khách lẻ");
            txtKhachTra.setEditable(false);
        }
        txtConLai.setText(txtTongThanhToan.getText());
        txtTongThanhToan.setText(String.valueOf(format.format(Tong)));
        txtKhachTra.addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                char c = e.getKeyChar();
                if (c >= '0' && c <= '9') {
                    txtKhachTra.setEditable(true);
                } else {
                    if (e.getExtendedKeyCode() == KeyEvent.VK_BACK_SPACE || e.getExtendedKeyCode() == KeyEvent.VK_DELETE) {
                        txtKhachTra.setEditable(true);
                    } else {
                        txtKhachTra.setEditable(false);
                    }
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                if (txtKhachTra.getText().length() != 0) {
                    if (Float.parseFloat(txtKhachTra.getText()) >= Float.parseFloat(txtTongThanhToan.getText())) {
                        txtKhachTra.setText(format.format(Float.parseFloat(txtTongThanhToan.getText())));
                    }
                    txtConLai.setText(format.format(Float.parseFloat(txtTongThanhToan.getText()) - Float.parseFloat(txtKhachTra.getText())));
                } else {
                    txtConLai.setText(txtTongThanhToan.getText());
                }
            }

        });

    }

    public boolean LuuHoaDonBan(HoaDonBanHangObj HDbobj) {
        if (txtKhachTra.getText().length() != 0) {
            HDbobj.setTienTra(Float.parseFloat(txtKhachTra.getText()));
        } else {
            HDbobj.setTienTra(0);
        }

        if (HDbobj.getKhachHang() == 0) {
            HDbobj.setKhachHang(3);
        }

        if (banHangService.upDateHoaDonBan(HDbobj)) {
            return true;
        } else {
            return false;
        }
    }

    public boolean upTienNo(HoaDonBanHangObj HDbobj) {
        if (txtConLai.getText().length() != 0) {
            HDbobj.setTienTra(Float.parseFloat(txtConLai.getText()));
        } else {
            HDbobj.setTienTra(Float.parseFloat(txtTongThanhToan.getText()));
        }
        if (banHangService.upTienNo(HDbobj)) {
            return true;
        } else {
            return false;
        }
    }

    public boolean LuuCTHDBanHang(List<CTHDBanHangObj> listCTHDB) {
        int check = 0;
        for (int i = 0; i < listCTHDB.size(); i++) {
            if (banHangService.upDateCTHDBan(listCTHDB.get(i))) {
                check = check + 1;
            }
        }
        if (check == listCTHDB.size()) {
            return true;
        } else {
            return false;
        }
    }

    public boolean CapNhapSL(List<CTHDBanHangObj> listCTHDB) {
        int check = 0;
        for (int i = 0; i < listCTHDB.size(); i++) {
            if (hangHoaService.upDateSLBanHang(listCTHDB.get(i).getSanPham(), listCTHDB.get(i).getSl())) {
                check = check + 1;
            }
        }
        if (check == listCTHDB.size()) {
            return true;
        } else {
            return false;
        }
    }

    public void setEvent(HoaDonBanHangObj HDbobj, List<CTHDBanHangObj> listCTHDB, BanHangJPanel banHangJPanel) {
        btnLuuKhongIn.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {

                if (listCTHDB.size() != 0) {
                    if (LuuHoaDonBan(HDbobj)) {
                        if (LuuCTHDBanHang(listCTHDB)) {
                            if (CapNhapSL(listCTHDB)) {
                                if (upTienNo(HDbobj)) {
                                    JOptionPane.showMessageDialog(null, "Tạo hóa đơn thành công");
                                    try (PrintWriter writer = new PrintWriter("BanHang.TXT")) {
                                        writer.print("");
                                        writer.close();
                                    } catch (Exception ex) {
                                        ex.printStackTrace();
                                    }
                                    banHangJPanel.setDateToTable();
                                    frame.dispose();

                                } else {
                                    JOptionPane.showMessageDialog(null, "Lỗi! không cập nhật được tiền nợ");
                                }
                            } else {
                                JOptionPane.showMessageDialog(null, "Lỗi! không cập nhật được số lượng");
                            }
                        } else {
                            JOptionPane.showMessageDialog(null, "Lỗi! không lưu được chi tiết hóa đơn ");
                        }
                    } else {
                        JOptionPane.showMessageDialog(null, "Lỗi! không lưu được hóa đơn");
                    }
                } else {
                    JOptionPane.showMessageDialog(null, "không có tên hàng");
                    frame.dispose();
                }
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnLuuKhongIn.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnLuuKhongIn.setBackground(new Color(0, 153, 0));
            }
        });

        btnHuy.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                frame.dispose();
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnLuuKhongIn.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnLuuKhongIn.setBackground(new Color(0, 153, 0));
            }
        });
    }

}
