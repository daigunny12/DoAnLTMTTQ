
package Controller.QuanLy.Add;

import Service.KhachHangService;
import Service.KhachHangServiceImpl;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JTextArea;
import Object.KhachHangObj;
import java.awt.Color;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import view.Menu.QuanLyView.KhachHangJPanel;

public class AddKhachHangController {
    private JButton btnSave;
    private JLabel lblThongBao;
    private JTextField txtTen;
    private JTextField txtMa;
    private JTextField txtSoNo;
    private JTextField txtSDT;
    private JTextArea txtDiaChi;
    private JTextArea txtGhiChu;
    
    private KhachHangObj khachHangObj = null;
    
    private KhachHangService khachHangService = null;

    public AddKhachHangController(JButton btnSave, JLabel lblThongBao, JTextField txtTen, JTextField txtMa, JTextField txtSoNo, JTextField txtSDT, JTextArea txtDiaChi, JTextArea txtGhiChu) {
        this.btnSave = btnSave;
        this.lblThongBao = lblThongBao;
        this.txtTen = txtTen;
        this.txtMa = txtMa;
        this.txtSoNo = txtSoNo;
        this.txtSDT = txtSDT;
        this.txtDiaChi = txtDiaChi;
        this.txtGhiChu = txtGhiChu;
        
        this.khachHangService = new KhachHangServiceImpl();
    }
    
    public void setView(KhachHangObj khachHangObj){
        this.khachHangObj = khachHangObj;
        txtMa.setEditable(false);
        txtMa.setText("#"+khachHangObj.getMaKH());
        txtTen.setText(khachHangObj.getTenKH());
        txtSoNo.setText((int)khachHangObj.getSoNo()+"");
        txtSDT.setText(khachHangObj.getSdt());
        txtDiaChi.setText(khachHangObj.getDiaChi());
        txtGhiChu.setText(khachHangObj.getGhiChu());
    }
    
    public void keyTXT(JTextField txt){
        txt.addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                char c = e.getKeyChar();
                if(c >='0' && c <='9' ){     
                        txt.setEditable(true);
                }else{
                    if(e.getExtendedKeyCode() == KeyEvent.VK_BACK_SPACE || e.getExtendedKeyCode() == KeyEvent.VK_DELETE){
                        txt.setEditable(true);
                    }else{
                        txt.setEditable(false);
                    }
                }
            }  
        });
        txt.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                txt.setEditable(true);
            }  
        });
    }
    
    public void setEvent(KhachHangJPanel khachHangJPanel){
        
        keyTXT(txtSoNo);
        
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
                if(txtTen.getText().length() != 0){
                    if(txtSDT.getText().length() !=0){
                        String sdt =txtSDT.getText();
                        String pattern = "0[0-9]{9}";
                        if(sdt.matches(pattern)){
                            if(txtDiaChi.getText().length() !=0){
                                LuuGiaTri(khachHangJPanel);
                            }else{
                                lblThongBao.setText("Bạn chưa nhập địa chỉ!");
                                txtDiaChi.requestFocus();
                            }
                        }else{
                            lblThongBao.setText("Số điện thoại không đúng!");
                            txtSDT.requestFocus();
                            txtSDT.setEditable(true);
                        }
                    }else{
                        lblThongBao.setText("Bạn chưa nhập sô điện thoại!");
                        txtSDT.requestFocus();
                    }
                }else{
                    lblThongBao.setText("Bạn chưa nhập tên khách hàng!");
                    txtTen.requestFocus();
                }
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                btnSave.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnSave.setBackground(new Color(0,153,0));
            }
            
            
        });
    }
    public void LuuGiaTri(KhachHangJPanel khachHangJPanel){
        khachHangObj.setTenKH(txtTen.getText());
        khachHangObj.setDiaChi(txtDiaChi.getText());
        khachHangObj.setSdt(txtSDT.getText());
        float sono = Float.parseFloat(txtSoNo.getText());
        khachHangObj.setSoNo(sono);
        khachHangObj.setGhiChu(txtGhiChu.getText());
        
        if(khachHangObj.getMaKH() == 0){
            if(khachHangService.AddTable(khachHangObj)){
                lblThongBao.setText("Lưu giá trị thành công");
                lblThongBao.setForeground(new Color(0, 153, 255));
                khachHangJPanel.addController();
            }else{
                lblThongBao.setText("Không lưu được");
            }
        }else{
            if(khachHangService.UpdateTable(khachHangObj)){
                lblThongBao.setText("Lưu giá trị thành công");
                lblThongBao.setForeground(new Color(0, 153, 255));
                khachHangJPanel.addController();
            }else{
                lblThongBao.setText("Không lưu được");
            }
        }
        
    }
}
