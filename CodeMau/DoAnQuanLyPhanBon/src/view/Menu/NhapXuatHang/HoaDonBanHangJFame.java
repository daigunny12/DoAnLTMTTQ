 
package view.Menu.NhapXuatHang;

import Object.CTHDBanHangObj;
import Object.HoaDonBanHangObj;
import java.util.List;
import view.Menu.BanHangJPanel;
import Controller.NhapXuatHang.HoaDonBanHangJFameCtrl;

public class HoaDonBanHangJFame extends javax.swing.JFrame {

    public HoaDonBanHangJFame(BanHangJPanel banHangJPanel ,List<CTHDBanHangObj> listCTHDB, HoaDonBanHangObj hdbhObj , String TenKhachHang ,float TongTien) {
        initComponents();
        HoaDonBanHangJFameCtrl hdCtrl = new HoaDonBanHangJFameCtrl(lblKhachHang, txtTongThanhToan, txtKhachTra, txtConLai, btnLuuVaIn, btnLuuKhongIn, btnHuy, this);
        hdCtrl.setLoad(TenKhachHang, TongTien);
        hdCtrl.setEvent(hdbhObj, listCTHDB, banHangJPanel);
    }

   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        btnLuuVaIn = new javax.swing.JButton();
        btnLuuKhongIn = new javax.swing.JButton();
        btnHuy = new javax.swing.JButton();
        txtTongThanhToan = new javax.swing.JTextField();
        txtKhachTra = new javax.swing.JTextField();
        txtConLai = new javax.swing.JTextField();
        lblKhachHang = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        jLabel1.setText("Khách hàng:");

        jLabel2.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        jLabel2.setText("Tổng thanh toán:");

        jLabel3.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        jLabel3.setText("Khách trả:");

        jLabel4.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        jLabel4.setText("Còn lại:");

        btnLuuVaIn.setBackground(new java.awt.Color(0, 153, 0));
        btnLuuVaIn.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        btnLuuVaIn.setForeground(new java.awt.Color(255, 255, 255));
        btnLuuVaIn.setText("Lưu và in");
        btnLuuVaIn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLuuVaInActionPerformed(evt);
            }
        });

        btnLuuKhongIn.setBackground(new java.awt.Color(0, 153, 0));
        btnLuuKhongIn.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        btnLuuKhongIn.setForeground(new java.awt.Color(255, 255, 255));
        btnLuuKhongIn.setText("Lưu không in");

        btnHuy.setBackground(new java.awt.Color(0, 153, 0));
        btnHuy.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        btnHuy.setForeground(new java.awt.Color(255, 255, 255));
        btnHuy.setText("Hủy");

        txtTongThanhToan.setEditable(false);
        txtTongThanhToan.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        txtTongThanhToan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtTongThanhToanActionPerformed(evt);
            }
        });

        txtKhachTra.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N

        txtConLai.setEditable(false);
        txtConLai.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N

        lblKhachHang.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(30, 30, 30)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btnLuuVaIn, javax.swing.GroupLayout.PREFERRED_SIZE, 155, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(10, 10, 10)
                        .addComponent(btnLuuKhongIn, javax.swing.GroupLayout.PREFERRED_SIZE, 155, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(10, 10, 10)
                        .addComponent(btnHuy, javax.swing.GroupLayout.PREFERRED_SIZE, 129, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(jLabel3, javax.swing.GroupLayout.DEFAULT_SIZE, 165, Short.MAX_VALUE)
                                .addComponent(jLabel4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                            .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 161, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtTongThanhToan)
                            .addComponent(txtKhachTra)
                            .addComponent(lblKhachHang, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(txtConLai))))
                .addGap(30, 30, 30))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(40, 40, 40)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addComponent(lblKhachHang))
                .addGap(35, 35, 35)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtTongThanhToan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(35, 35, 35)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel3)
                            .addComponent(txtKhachTra, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(35, 35, 35)
                        .addComponent(jLabel4))
                    .addComponent(txtConLai, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(40, 40, 40)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnLuuVaIn, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnLuuKhongIn, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnHuy, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(69, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtTongThanhToanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtTongThanhToanActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtTongThanhToanActionPerformed

    private void btnLuuVaInActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLuuVaInActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_btnLuuVaInActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnHuy;
    private javax.swing.JButton btnLuuKhongIn;
    private javax.swing.JButton btnLuuVaIn;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel lblKhachHang;
    private javax.swing.JTextField txtConLai;
    private javax.swing.JTextField txtKhachTra;
    private javax.swing.JTextField txtTongThanhToan;
    // End of variables declaration//GEN-END:variables
}
