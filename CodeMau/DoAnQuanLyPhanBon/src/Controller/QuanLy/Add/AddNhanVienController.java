package Controller.QuanLy.Add;

import javax.swing.JButton;
import javax.swing.JTextField;
import Object.NhanVienObj;
import com.toedter.calendar.JDateChooser;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JLabel;
import javax.swing.JRadioButton;
import javax.swing.JTextArea;
import Service.NhanVienService;
import Service.NhanVienServiceImpl;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import view.Menu.QuanLyView.NhanVienJPanel;

public class AddNhanVienController {

    private JButton btnSave;
    private JLabel lblThongBao;
    private JTextField txtTen;
    private JTextField txtMa;
    private JDateChooser dcNgaySinh;
    private JRadioButton rdoNam;
    private JRadioButton rdoNu;
    private JTextField txtSDT;
    private JTextArea txtDiaChi;
    private JTextArea txtGhiChu;

    private NhanVienObj nhanVienObj = null;

    private NhanVienService nhanVienService = null;

    public AddNhanVienController(JButton btnSave, JLabel lblThongBao, JTextField txtTen, JTextField txtMa, JDateChooser dcNgaySinh, JRadioButton rdoNam, JRadioButton rdoNu, JTextField txtSDT, JTextArea txtDiaChi, JTextArea txtGhiChu) {
        this.btnSave = btnSave;
        this.lblThongBao = lblThongBao;
        this.txtTen = txtTen;
        this.txtMa = txtMa;
        this.dcNgaySinh = dcNgaySinh;
        this.rdoNam = rdoNam;
        this.rdoNu = rdoNu;
        this.txtSDT = txtSDT;
        this.txtDiaChi = txtDiaChi;
        this.txtGhiChu = txtGhiChu;

        this.nhanVienService = new NhanVienServiceImpl();
    }

    public void setView(NhanVienObj nhanVienObj) {
        this.nhanVienObj = nhanVienObj;

        txtMa.setEditable(false);
        txtMa.setText("#" + nhanVienObj.getMaNV());
        txtTen.setText(nhanVienObj.getTenNV());
        dcNgaySinh.setDate(nhanVienObj.getNgaySinh());
        String gt = null;
        gt = nhanVienObj.getGioiTinh();
        rdoNam.setSelected(true);
        if (gt != null) {
            if (gt.equals("Nam")) {
                rdoNam.setSelected(true);
            } else {
                rdoNu.setSelected(true);
            }
        } else {
            rdoNam.setSelected(false);
            rdoNu.setSelected(false);
        }

        txtSDT.setText(nhanVienObj.getSdt());
        txtDiaChi.setText(nhanVienObj.getDiaChi());
        txtGhiChu.setText(nhanVienObj.getGhiChu());
    }

    public void setEvent(NhanVienJPanel nhanVienJPanel) {
        txtSDT.addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                String phoneNumber = txtSDT.getText();
                int length = phoneNumber.length();
                char c = e.getKeyChar();
                if(c >='0' && c <='9' ){
                    if(length<10){
                        txtSDT.setEditable(true);
                    }else{
                        txtSDT.setEditable(false);
                        lblThongBao.setText("Nhập chi nhiều dữ cha nội!!");
                    }
                }else{
                    if(e.getExtendedKeyCode() == KeyEvent.VK_BACK_SPACE || e.getExtendedKeyCode() == KeyEvent.VK_DELETE){
                        txtSDT.setEditable(true);
                        lblThongBao.setText("...");
                    }else{
                        txtSDT.setEditable(false);
                    }
                }
            }
            
        });
        
        btnSave.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (txtTen.getText().length() != 0) {
                    if (dcNgaySinh.getDate() != null) {
                        if (txtSDT.getText().length() != 0) {
                            String pattern = "0[0-9]{9}";
                            String mobi = txtSDT.getText();
                            if (mobi.matches(pattern)) {
                                if (txtDiaChi.getText().length() != 0) {
                                    LuuGiaTri(nhanVienJPanel);
                                    
                                } else {
                                    lblThongBao.setText("Bạn chưa nhập địa chỉ!");
                                    txtDiaChi.requestFocus();
                                }
                            } else {
                                lblThongBao.setText("không đúng số điện thoại!");
                                txtSDT.setEditable(true);
                                txtSDT.requestFocus();
                            }
                        } else {
                            lblThongBao.setText("Bạn chưa nhập số điện thoại!");
                            txtSDT.requestFocus();
                        }
                    } else {
                        lblThongBao.setText("Bạn chưa nhập ngày tháng hoặc nhập sai!");
                        dcNgaySinh.requestFocus();
                    }
                } else {
                    lblThongBao.setText("Bạn chưa nhập tên nhân viên!");
                    txtTen.requestFocus();
                }
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnSave.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnSave.setBackground(new Color(0, 153, 0));
            }
        });
    }

    public void LuuGiaTri(NhanVienJPanel nhanVienJPanel) {
        nhanVienObj.setTenNV(txtTen.getText());
        if (rdoNam.isSelected()) {
            nhanVienObj.setGioiTinh("Nam");
        }
        if (rdoNu.isSelected()) {
            nhanVienObj.setGioiTinh("Nữ");
        }
        nhanVienObj.setNgaySinh(dcNgaySinh.getDate());
        nhanVienObj.setDiaChi(txtDiaChi.getText());
        nhanVienObj.setSdt(txtSDT.getText());
        nhanVienObj.setGhiChu(txtGhiChu.getText());
        if (nhanVienObj.getMaNV() == 0) {
            if (new NhanVienServiceImpl().AddTable(nhanVienObj)) {
                lblThongBao.setText("Lưu giá trị thành công");
                lblThongBao.setForeground(new Color(0, 153, 255));
                nhanVienJPanel.addController();
            } else {
                lblThongBao.setText("Không lưu được");
            }
        } else {
            if (new NhanVienServiceImpl().UpdateTable(nhanVienObj)) {
                lblThongBao.setText("Lưu giá trị thành công");
                lblThongBao.setForeground(new Color(0, 153, 255));
                nhanVienJPanel.addController();
            } else {
                lblThongBao.setText("Không lưu được");
            }
        }
    }

}
