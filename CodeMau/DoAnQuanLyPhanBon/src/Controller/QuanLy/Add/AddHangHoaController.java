package Controller.QuanLy.Add;

import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import Service.HangHoaService;
import Service.HangHoaServiceImpl;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import Object.HangHoaObj;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import view.Menu.QuanLyView.HangHoaJPanel;

public class AddHangHoaController {

    private JButton btnSave;
    private JLabel lblThongBao;
    private JTextField txtTen;
    private JTextField txtMa;
    private JTextField txtDVT;
    private JTextField txtSL;
    private JTextField txtGiaBan;
    private JTextField txtGiaMua;
    private JTextField txtGhiChu;

    private HangHoaObj hangHoaObj;

    private HangHoaService hangHoaService = null;

    public AddHangHoaController(JButton btnSave, JLabel lblThongBao, JTextField txtTen, JTextField txtMa, JTextField txtDVT, JTextField txtSL, JTextField txtGiaBan, JTextField txtGiaMua, JTextField txtGhiChu) {
        this.btnSave = btnSave;
        this.lblThongBao = lblThongBao;
        this.txtTen = txtTen;
        this.txtMa = txtMa;
        this.txtDVT = txtDVT;
        this.txtSL = txtSL;
        this.txtGiaBan = txtGiaBan;
        this.txtGiaMua = txtGiaMua;
        this.txtGhiChu = txtGhiChu;

        this.hangHoaService = new HangHoaServiceImpl();
    }

    public void setView(HangHoaObj hangHoaObj) {
        this.hangHoaObj = hangHoaObj;
        txtMa.setEditable(false);
        txtMa.setText("#" + hangHoaObj.getMaHH());
        txtTen.setText(hangHoaObj.getTeHH());
        txtDVT.setText(hangHoaObj.getDonViTinh());
        txtSL.setText(hangHoaObj.getSl() + "");
        txtGiaBan.setText((int)hangHoaObj.getGiaBan() + "");
        txtGiaMua.setText((int)hangHoaObj.getGiaMua() + "");
        txtGhiChu.setText(hangHoaObj.getGhiChu());       
        txtSL.setEnabled(false);      
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
    
    public void setEvent(HangHoaJPanel hangHoaJPanel) {
        keyTXT(txtSL);
        keyTXT(txtGiaBan);
        keyTXT(txtGiaMua);
        
        btnSave.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if(txtTen.getText().length() !=0){
                    if(txtDVT.getText().length() != 0){
                        LuuGiaTri(hangHoaJPanel);
                    }else{
                        lblThongBao.setText("Chưa có đơn vị tính");
                        txtDVT.requestFocus();
                    }
                }else{
                    lblThongBao.setText("Bạn chưa nhập tên sản phẩm!");
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

    public void LuuGiaTri(HangHoaJPanel hangHoaJPanel) {
        hangHoaObj.setTeHH(txtTen.getText());
        hangHoaObj.setDonViTinh(txtDVT.getText());
        float gb = Float.parseFloat(txtGiaBan.getText());
        float gm = Float.parseFloat(txtGiaMua.getText());
        int sl = Integer.parseInt(txtSL.getText());
        hangHoaObj.setGiaBan(gb);
        hangHoaObj.setGiaMua(gm);
        hangHoaObj.setSl(sl);
        hangHoaObj.setGhiChu(txtGhiChu.getText());

        if (hangHoaObj.getMaHH() == 0) {
            if (hangHoaService.AddTable(hangHoaObj)) {
                lblThongBao.setText("Lưu giá trị thành công");
                lblThongBao.setForeground(new Color(0, 153, 255));
                hangHoaJPanel.addController();
            } else {
                lblThongBao.setText("Không lưu được");
            }
        } else {
            if (hangHoaService.UpdateTable(hangHoaObj)) {
                lblThongBao.setText("Lưu giá trị thành công");
                lblThongBao.setForeground(new Color(0, 153, 255));
                hangHoaJPanel.addController();
            } else {
                lblThongBao.setText("Không lưu được");
            }
        }
    }
}
