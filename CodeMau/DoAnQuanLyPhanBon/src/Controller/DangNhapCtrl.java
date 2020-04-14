
package Controller;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPasswordField;
import Object.TaiKhoanObj;
import Service.DangNhapService;
import Service.DangNhapServiceImpl;
import java.awt.Dialog;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.JFrame;
import view.Main.MainJFrame;

public class DangNhapCtrl {
    private Dialog dialog;
    private JTextField txtName;
    private JButton btnDangNhap;
    private JLabel lblThongBao;
    private JPasswordField txtPassword;
    private JButton btnHuy;

    private DangNhapService dangNhapService = null;
    
    public String chucVu = null;

    
    public DangNhapCtrl(Dialog dialog ,JTextField txtName, JButton btnDangNhap, JLabel lblThongBao, JPasswordField txtPassword,JButton btnHuy) {
        this.dialog = dialog;
        this.txtName = txtName;
        this.btnDangNhap = btnDangNhap;
        this.lblThongBao = lblThongBao;
        this.txtPassword = txtPassword;
        this.btnHuy = btnHuy;
        
        this.dangNhapService = new  DangNhapServiceImpl();
    }
    
    public void setEvent(){
        btnDangNhap.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                btnDangNhap.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnDangNhap.setBackground(new Color(51, 204, 51));
            }

            @Override
            public void mouseClicked(MouseEvent e) {
               checktxt();
                
            }
        });
        
        btnHuy.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                btnHuy.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnHuy.setBackground(new Color(51, 204, 51));
            }

            @Override
            public void mouseClicked(MouseEvent e) {
                dialog.dispose();
            }
            
            
        });
        
        
        txtName.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                if(e.getKeyCode() == e.VK_ENTER){
                    txtPassword.requestFocus();
                }
            }
            
        });
        
        txtPassword.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                if(e.getKeyCode() == e.VK_ENTER){
                    checktxt();
                }
            }
            
        });
        
        
    }
    public void checktxt(){
        if(txtName.getText().length() != 0){
                    if(String.valueOf(txtPassword.getPassword()).length() != 0){
                        DangNhap();
                    }else{
                        lblThongBao.setText("Bạn chưa nhập mật khẩu");
                        txtPassword.requestFocus();
                    }
                }else{
                    lblThongBao.setText("Bạn chưa nhập Tên đăng nhập!");
                    txtName.requestFocus();
                }
    }
    
    
    public void DangNhap(){
        TaiKhoanObj taiKhoanObj = dangNhapService.DangNhap(txtName.getText(), String.valueOf(txtPassword.getPassword()));
        if(taiKhoanObj == null){
            lblThongBao.setText("Tên đăng nhập hoặc mật khẩu không đúng!");
        }else{
            dialog.dispose();
            MainJFrame mainJFrame = new MainJFrame(taiKhoanObj);
            mainJFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);
            mainJFrame.setVisible(true);
        }
    }
    
}
