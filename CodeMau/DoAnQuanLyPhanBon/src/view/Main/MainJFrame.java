
package view.Main;

import Controller.ChuyenManHinhCtrl;
import java.util.ArrayList;
import Object.DanhMucObj;
import java.util.List;
import Object.TaiKhoanObj;
import java.awt.Color;

public class MainJFrame extends javax.swing.JFrame {


    public MainJFrame(TaiKhoanObj taiKhoanObj) {
        initComponents();
        setTitle("Quản lý của hàng"); 
        
        ChuyenManHinhCtrl ctrl = new ChuyenManHinhCtrl(pnView);
        ctrl.setView(pnManHinhChinh, lblManHinhChinh);
        
        List<DanhMucObj> listItem =new  ArrayList<>();
        listItem.add(new DanhMucObj("TrangChu",pnManHinhChinh,lblManHinhChinh));
        listItem.add(new DanhMucObj("HeThong",pnHeThong,lblHeThong));
        String chucvu = taiKhoanObj.getChucVu();
        if( !"Quản lý".equals(chucvu)){
            pnQuanLy.setBackground(Color.red);
            pnNhapHang.setBackground(Color.red);
            pnThongKe.setBackground(Color.red);
        }else{
            listItem.add(new DanhMucObj("QuanLy",pnQuanLy,lblQuanLy));
            listItem.add(new DanhMucObj("NhapHang",pnNhapHang,lblNhapHang));
            listItem.add(new DanhMucObj("ThongKe",pnThongKe,lblThongKe));
        }
        
        listItem.add(new DanhMucObj("BanHang",pnBanHang,lblBanHang));
        
        
        ctrl.setEvent(listItem ,taiKhoanObj);
        
    }

 


    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnRoot = new javax.swing.JPanel();
        pnMenu = new javax.swing.JPanel();
        pnName = new javax.swing.JPanel();
        lblName = new javax.swing.JLabel();
        pnManHinhChinh = new javax.swing.JPanel();
        lblManHinhChinh = new javax.swing.JLabel();
        pnHeThong = new javax.swing.JPanel();
        lblHeThong = new javax.swing.JLabel();
        pnNhapHang = new javax.swing.JPanel();
        lblNhapHang = new javax.swing.JLabel();
        pnQuanLy = new javax.swing.JPanel();
        lblQuanLy = new javax.swing.JLabel();
        pnBanHang = new javax.swing.JPanel();
        lblBanHang = new javax.swing.JLabel();
        pnThongKe = new javax.swing.JPanel();
        lblThongKe = new javax.swing.JLabel();
        pnView = new javax.swing.JPanel();
        pnLe = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        pnMenu.setBackground(new java.awt.Color(102, 51, 0));

        pnName.setBackground(new java.awt.Color(230, 0, 0));

        lblName.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblName.setForeground(new java.awt.Color(255, 255, 255));
        lblName.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconStore.png"))); // NOI18N
        lblName.setText("CỦA HÀNG PHÂN BÓN");

        javax.swing.GroupLayout pnNameLayout = new javax.swing.GroupLayout(pnName);
        pnName.setLayout(pnNameLayout);
        pnNameLayout.setHorizontalGroup(
            pnNameLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnNameLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblName, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        pnNameLayout.setVerticalGroup(
            pnNameLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnNameLayout.createSequentialGroup()
                .addContainerGap(20, Short.MAX_VALUE)
                .addComponent(lblName)
                .addContainerGap())
        );

        pnManHinhChinh.setBackground(new java.awt.Color(102, 0, 255));

        lblManHinhChinh.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblManHinhChinh.setForeground(new java.awt.Color(255, 255, 255));
        lblManHinhChinh.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconLapTop.png"))); // NOI18N
        lblManHinhChinh.setText("Màn hình chính");

        javax.swing.GroupLayout pnManHinhChinhLayout = new javax.swing.GroupLayout(pnManHinhChinh);
        pnManHinhChinh.setLayout(pnManHinhChinhLayout);
        pnManHinhChinhLayout.setHorizontalGroup(
            pnManHinhChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnManHinhChinhLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblManHinhChinh, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnManHinhChinhLayout.setVerticalGroup(
            pnManHinhChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnManHinhChinhLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblManHinhChinh)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnHeThong.setBackground(new java.awt.Color(102, 0, 255));

        lblHeThong.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblHeThong.setForeground(new java.awt.Color(255, 255, 255));
        lblHeThong.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconSetting.png"))); // NOI18N
        lblHeThong.setText("Hệ thống");

        javax.swing.GroupLayout pnHeThongLayout = new javax.swing.GroupLayout(pnHeThong);
        pnHeThong.setLayout(pnHeThongLayout);
        pnHeThongLayout.setHorizontalGroup(
            pnHeThongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnHeThongLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblHeThong, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnHeThongLayout.setVerticalGroup(
            pnHeThongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnHeThongLayout.createSequentialGroup()
                .addGap(10, 10, 10)
                .addComponent(lblHeThong)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnNhapHang.setBackground(new java.awt.Color(102, 0, 255));

        lblNhapHang.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblNhapHang.setForeground(new java.awt.Color(255, 255, 255));
        lblNhapHang.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconNhapHang.png"))); // NOI18N
        lblNhapHang.setText("Nhập hàng");

        javax.swing.GroupLayout pnNhapHangLayout = new javax.swing.GroupLayout(pnNhapHang);
        pnNhapHang.setLayout(pnNhapHangLayout);
        pnNhapHangLayout.setHorizontalGroup(
            pnNhapHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnNhapHangLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblNhapHang, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnNhapHangLayout.setVerticalGroup(
            pnNhapHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnNhapHangLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblNhapHang)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnQuanLy.setBackground(new java.awt.Color(102, 0, 255));

        lblQuanLy.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblQuanLy.setForeground(new java.awt.Color(255, 255, 255));
        lblQuanLy.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconQuanLy.png"))); // NOI18N
        lblQuanLy.setText("Quản lý");

        javax.swing.GroupLayout pnQuanLyLayout = new javax.swing.GroupLayout(pnQuanLy);
        pnQuanLy.setLayout(pnQuanLyLayout);
        pnQuanLyLayout.setHorizontalGroup(
            pnQuanLyLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnQuanLyLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblQuanLy, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnQuanLyLayout.setVerticalGroup(
            pnQuanLyLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnQuanLyLayout.createSequentialGroup()
                .addGap(10, 10, 10)
                .addComponent(lblQuanLy)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnBanHang.setBackground(new java.awt.Color(102, 0, 255));

        lblBanHang.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblBanHang.setForeground(new java.awt.Color(255, 255, 255));
        lblBanHang.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconBan.png"))); // NOI18N
        lblBanHang.setText("Bán hàng");

        javax.swing.GroupLayout pnBanHangLayout = new javax.swing.GroupLayout(pnBanHang);
        pnBanHang.setLayout(pnBanHangLayout);
        pnBanHangLayout.setHorizontalGroup(
            pnBanHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnBanHangLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblBanHang, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnBanHangLayout.setVerticalGroup(
            pnBanHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnBanHangLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblBanHang)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnThongKe.setBackground(new java.awt.Color(102, 0, 255));

        lblThongKe.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblThongKe.setForeground(new java.awt.Color(255, 255, 255));
        lblThongKe.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconThongKe.png"))); // NOI18N
        lblThongKe.setText("Thống kê");

        javax.swing.GroupLayout pnThongKeLayout = new javax.swing.GroupLayout(pnThongKe);
        pnThongKe.setLayout(pnThongKeLayout);
        pnThongKeLayout.setHorizontalGroup(
            pnThongKeLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnThongKeLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblThongKe, javax.swing.GroupLayout.PREFERRED_SIZE, 255, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnThongKeLayout.setVerticalGroup(
            pnThongKeLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnThongKeLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblThongKe)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout pnMenuLayout = new javax.swing.GroupLayout(pnMenu);
        pnMenu.setLayout(pnMenuLayout);
        pnMenuLayout.setHorizontalGroup(
            pnMenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnName, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(pnMenuLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnMenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(pnManHinhChinh, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnHeThong, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnNhapHang, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnQuanLy, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnBanHang, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnThongKe, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );
        pnMenuLayout.setVerticalGroup(
            pnMenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnMenuLayout.createSequentialGroup()
                .addComponent(pnName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(12, 12, 12)
                .addComponent(pnManHinhChinh, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(12, 12, 12)
                .addComponent(pnHeThong, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(12, 12, 12)
                .addComponent(pnQuanLy, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(12, 12, 12)
                .addComponent(pnNhapHang, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(12, 12, 12)
                .addComponent(pnBanHang, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(12, 12, 12)
                .addComponent(pnThongKe, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout pnViewLayout = new javax.swing.GroupLayout(pnView);
        pnView.setLayout(pnViewLayout);
        pnViewLayout.setHorizontalGroup(
            pnViewLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 806, Short.MAX_VALUE)
        );
        pnViewLayout.setVerticalGroup(
            pnViewLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        pnLe.setBackground(new java.awt.Color(102, 255, 51));

        javax.swing.GroupLayout pnLeLayout = new javax.swing.GroupLayout(pnLe);
        pnLe.setLayout(pnLeLayout);
        pnLeLayout.setHorizontalGroup(
            pnLeLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 8, Short.MAX_VALUE)
        );
        pnLeLayout.setVerticalGroup(
            pnLeLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout pnRootLayout = new javax.swing.GroupLayout(pnRoot);
        pnRoot.setLayout(pnRootLayout);
        pnRootLayout.setHorizontalGroup(
            pnRootLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnRootLayout.createSequentialGroup()
                .addComponent(pnMenu, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, 0)
                .addComponent(pnLe, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, 0)
                .addComponent(pnView, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(0, 0, 0))
        );
        pnRootLayout.setVerticalGroup(
            pnRootLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnView, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(pnMenu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(pnLe, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnRoot, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(pnRoot, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(0, 0, 0))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel lblBanHang;
    private javax.swing.JLabel lblHeThong;
    private javax.swing.JLabel lblManHinhChinh;
    private javax.swing.JLabel lblName;
    private javax.swing.JLabel lblNhapHang;
    private javax.swing.JLabel lblQuanLy;
    private javax.swing.JLabel lblThongKe;
    private javax.swing.JPanel pnBanHang;
    private javax.swing.JPanel pnHeThong;
    private javax.swing.JPanel pnLe;
    private javax.swing.JPanel pnManHinhChinh;
    private javax.swing.JPanel pnMenu;
    private javax.swing.JPanel pnName;
    private javax.swing.JPanel pnNhapHang;
    private javax.swing.JPanel pnQuanLy;
    private javax.swing.JPanel pnRoot;
    private javax.swing.JPanel pnThongKe;
    private javax.swing.JPanel pnView;
    // End of variables declaration//GEN-END:variables
}
