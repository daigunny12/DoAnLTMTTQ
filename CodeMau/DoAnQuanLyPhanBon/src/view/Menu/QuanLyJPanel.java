
package view.Menu;

import Controller.ChuyenJPanelQuanLyCtrl;
import java.util.ArrayList;
import Object.DanhMucObj;
import java.util.List;

public class QuanLyJPanel extends javax.swing.JPanel {

   
    public QuanLyJPanel() {
        initComponents();
        ChuyenJPanelQuanLyCtrl ctrl = new ChuyenJPanelQuanLyCtrl(pnView);
        ctrl.setView(pnHangHoa, lblHangHoa);
        
        List<DanhMucObj> listItem =new  ArrayList<>();
        listItem.add(new DanhMucObj("HangHoa",pnHangHoa,lblHangHoa));
        listItem.add(new DanhMucObj("NhanVien",pnNhanVien,lblNhanVien));
        listItem.add(new DanhMucObj("KhachHang",pnKhachHang,lblKhachHang));
        listItem.add(new DanhMucObj("NhaCungCap",pnNhaCungCap,lblNhaCungCap));
        
        ctrl.setEvent(listItem);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnChinh = new javax.swing.JPanel();
        pnMenu = new javax.swing.JPanel();
        pnHangHoa = new javax.swing.JPanel();
        lblHangHoa = new javax.swing.JLabel();
        pnNhanVien = new javax.swing.JPanel();
        lblNhanVien = new javax.swing.JLabel();
        pnKhachHang = new javax.swing.JPanel();
        lblKhachHang = new javax.swing.JLabel();
        pnNhaCungCap = new javax.swing.JPanel();
        lblNhaCungCap = new javax.swing.JLabel();
        pnView = new javax.swing.JPanel();

        pnChinh.setBackground(new java.awt.Color(204, 204, 255));

        pnMenu.setPreferredSize(new java.awt.Dimension(824, 78));

        pnHangHoa.setBackground(new java.awt.Color(0, 153, 0));
        pnHangHoa.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        pnHangHoa.setPreferredSize(new java.awt.Dimension(182, 78));

        lblHangHoa.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblHangHoa.setForeground(new java.awt.Color(255, 255, 255));
        lblHangHoa.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconHangHoa.png"))); // NOI18N
        lblHangHoa.setText("HÀNG HÓA");

        javax.swing.GroupLayout pnHangHoaLayout = new javax.swing.GroupLayout(pnHangHoa);
        pnHangHoa.setLayout(pnHangHoaLayout);
        pnHangHoaLayout.setHorizontalGroup(
            pnHangHoaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnHangHoaLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblHangHoa, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(47, 47, 47))
        );
        pnHangHoaLayout.setVerticalGroup(
            pnHangHoaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnHangHoaLayout.createSequentialGroup()
                .addContainerGap(20, Short.MAX_VALUE)
                .addComponent(lblHangHoa)
                .addGap(10, 10, 10))
        );

        pnNhanVien.setBackground(new java.awt.Color(0, 153, 0));
        pnNhanVien.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        pnNhanVien.setPreferredSize(new java.awt.Dimension(182, 78));

        lblNhanVien.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblNhanVien.setForeground(new java.awt.Color(255, 255, 255));
        lblNhanVien.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconNhanVien.png"))); // NOI18N
        lblNhanVien.setText("NHÂN VIÊN");

        javax.swing.GroupLayout pnNhanVienLayout = new javax.swing.GroupLayout(pnNhanVien);
        pnNhanVien.setLayout(pnNhanVienLayout);
        pnNhanVienLayout.setHorizontalGroup(
            pnNhanVienLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnNhanVienLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblNhanVien, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(21, 21, 21))
        );
        pnNhanVienLayout.setVerticalGroup(
            pnNhanVienLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnNhanVienLayout.createSequentialGroup()
                .addContainerGap(20, Short.MAX_VALUE)
                .addComponent(lblNhanVien)
                .addGap(10, 10, 10))
        );

        pnKhachHang.setBackground(new java.awt.Color(0, 153, 0));
        pnKhachHang.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        pnKhachHang.setPreferredSize(new java.awt.Dimension(182, 78));

        lblKhachHang.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblKhachHang.setForeground(new java.awt.Color(255, 255, 255));
        lblKhachHang.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconKhachHang.png"))); // NOI18N
        lblKhachHang.setText("KHÁCH HÀNG");

        javax.swing.GroupLayout pnKhachHangLayout = new javax.swing.GroupLayout(pnKhachHang);
        pnKhachHang.setLayout(pnKhachHangLayout);
        pnKhachHangLayout.setHorizontalGroup(
            pnKhachHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnKhachHangLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblKhachHang, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        pnKhachHangLayout.setVerticalGroup(
            pnKhachHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnKhachHangLayout.createSequentialGroup()
                .addContainerGap(20, Short.MAX_VALUE)
                .addComponent(lblKhachHang)
                .addGap(10, 10, 10))
        );

        pnNhaCungCap.setBackground(new java.awt.Color(0, 153, 0));
        pnNhaCungCap.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        pnNhaCungCap.setPreferredSize(new java.awt.Dimension(182, 78));

        lblNhaCungCap.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblNhaCungCap.setForeground(new java.awt.Color(255, 255, 255));
        lblNhaCungCap.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Icon/iconNhaCungCap.png"))); // NOI18N
        lblNhaCungCap.setText("NHÀ CUNG CẤP");

        javax.swing.GroupLayout pnNhaCungCapLayout = new javax.swing.GroupLayout(pnNhaCungCap);
        pnNhaCungCap.setLayout(pnNhaCungCapLayout);
        pnNhaCungCapLayout.setHorizontalGroup(
            pnNhaCungCapLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnNhaCungCapLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblNhaCungCap, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        pnNhaCungCapLayout.setVerticalGroup(
            pnNhaCungCapLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnNhaCungCapLayout.createSequentialGroup()
                .addContainerGap(20, Short.MAX_VALUE)
                .addComponent(lblNhaCungCap)
                .addGap(10, 10, 10))
        );

        javax.swing.GroupLayout pnMenuLayout = new javax.swing.GroupLayout(pnMenu);
        pnMenu.setLayout(pnMenuLayout);
        pnMenuLayout.setHorizontalGroup(
            pnMenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnMenuLayout.createSequentialGroup()
                .addComponent(pnHangHoa, javax.swing.GroupLayout.DEFAULT_SIZE, 213, Short.MAX_VALUE)
                .addGap(1, 1, 1)
                .addComponent(pnNhanVien, javax.swing.GroupLayout.DEFAULT_SIZE, 192, Short.MAX_VALUE)
                .addGap(1, 1, 1)
                .addComponent(pnKhachHang, javax.swing.GroupLayout.DEFAULT_SIZE, 193, Short.MAX_VALUE)
                .addGap(1, 1, 1)
                .addComponent(pnNhaCungCap, javax.swing.GroupLayout.DEFAULT_SIZE, 223, Short.MAX_VALUE)
                .addGap(0, 0, 0))
        );
        pnMenuLayout.setVerticalGroup(
            pnMenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnMenuLayout.createSequentialGroup()
                .addGroup(pnMenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(pnNhanVien, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pnHangHoa, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pnKhachHang, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pnNhaCungCap, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(0, 0, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout pnViewLayout = new javax.swing.GroupLayout(pnView);
        pnView.setLayout(pnViewLayout);
        pnViewLayout.setHorizontalGroup(
            pnViewLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        pnViewLayout.setVerticalGroup(
            pnViewLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 344, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout pnChinhLayout = new javax.swing.GroupLayout(pnChinh);
        pnChinh.setLayout(pnChinhLayout);
        pnChinhLayout.setHorizontalGroup(
            pnChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnMenu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(pnView, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        pnChinhLayout.setVerticalGroup(
            pnChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnChinhLayout.createSequentialGroup()
                .addComponent(pnMenu, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnView, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnChinh, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnChinh, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel lblHangHoa;
    private javax.swing.JLabel lblKhachHang;
    private javax.swing.JLabel lblNhaCungCap;
    private javax.swing.JLabel lblNhanVien;
    private javax.swing.JPanel pnChinh;
    private javax.swing.JPanel pnHangHoa;
    private javax.swing.JPanel pnKhachHang;
    private javax.swing.JPanel pnMenu;
    private javax.swing.JPanel pnNhaCungCap;
    private javax.swing.JPanel pnNhanVien;
    private javax.swing.JPanel pnView;
    // End of variables declaration//GEN-END:variables
}
