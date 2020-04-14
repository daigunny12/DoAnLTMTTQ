
package Main;

import view.Main.DangNhapJDialog;


public class Main {

    
    public static void main(String[] args) {
       DangNhapJDialog dialog = new DangNhapJDialog(null, true);
       dialog.setTitle("Đăng nhập hệ thống");
       dialog.setLocationRelativeTo(null);
       dialog.setResizable(false);
       dialog.setVisible(true);
       
    }
    
}
