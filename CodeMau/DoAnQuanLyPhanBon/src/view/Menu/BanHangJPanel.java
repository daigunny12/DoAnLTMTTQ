package view.Menu;

import Object.TaiKhoanObj;
import Controller.NhapXuatHang.BanHangJPanelCtrl;
import Object.KhachHangObj;

public class BanHangJPanel extends javax.swing.JPanel {

    private TaiKhoanObj taiKhoanObj = null;
    public BanHangJPanel(TaiKhoanObj taiKhoanObj) {
        initComponents();
        BanHangJPanelCtrl banHangCtrl = new  BanHangJPanelCtrl(lblTenNV, lblNgay, btnKhachHang, btnAdd, lblDiaChi, lblSDT, lblSoNo, lblGhiChu, pnTable, btnNew, btnThanhToan, lblTongTenHang, lblTongSL, lblTongCong, lblMaNV, lblMaKhachHang);
        banHangCtrl.setView(taiKhoanObj);
        banHangCtrl.setEvent();
        banHangCtrl.setDateToTable();
        banHangCtrl.setTong();
        it = this;
    }

    public static BanHangJPanel it;

    public void LoadKhachHang(KhachHangObj khachHangObj) {
        BanHangJPanelCtrl banHangCtrl = new  BanHangJPanelCtrl(lblTenNV, lblNgay, btnKhachHang, btnAdd, lblDiaChi, lblSDT, lblSoNo, lblGhiChu, pnTable, btnNew, btnThanhToan, lblTongTenHang, lblTongSL, lblTongCong, lblMaNV,lblMaKhachHang);
        banHangCtrl.loadKhachHang(khachHangObj);
        banHangCtrl.setTong();
    }

    public void setDateToTable() {
        BanHangJPanelCtrl banHangJPanelCtrl = new BanHangJPanelCtrl(lblTenNV, lblNgay, btnKhachHang, btnAdd, lblDiaChi, lblSDT, lblSoNo, lblGhiChu, pnTable, btnNew, btnThanhToan, lblTongTenHang, lblTongSL, lblTongCong, lblMaNV, lblMaKhachHang);
        banHangJPanelCtrl.setDateToTable();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnChinh = new javax.swing.JPanel();
        pnTitle = new javax.swing.JPanel();
        lblTitle = new javax.swing.JLabel();
        btnThanhToan = new javax.swing.JButton();
        pnThonhTin = new javax.swing.JPanel();
        lbl1 = new javax.swing.JLabel();
        lblNgay = new javax.swing.JLabel();
        lbl2 = new javax.swing.JLabel();
        lblTenNV = new javax.swing.JLabel();
        btnKhachHang = new javax.swing.JButton();
        lbl3 = new javax.swing.JLabel();
        lbl4 = new javax.swing.JLabel();
        lbl5 = new javax.swing.JLabel();
        lblGhiChu = new javax.swing.JLabel();
        lbl8 = new javax.swing.JLabel();
        lblDiaChi = new javax.swing.JLabel();
        lblSDT = new javax.swing.JLabel();
        btnAdd = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        lblSoNo = new javax.swing.JLabel();
        lbl6 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        lblTongTenHang = new javax.swing.JLabel();
        lblTongSL = new javax.swing.JLabel();
        lblTongCong = new javax.swing.JLabel();
        btnNew = new javax.swing.JButton();
        lblMaNV = new javax.swing.JLabel();
        lblMaKhachHang = new javax.swing.JLabel();
        pnTable = new javax.swing.JPanel();

        setForeground(new java.awt.Color(255, 255, 255));

        pnChinh.setBackground(new java.awt.Color(255, 255, 153));

        pnTitle.setBackground(new java.awt.Color(255, 51, 102));

        lblTitle.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        lblTitle.setText("BÁN HÀNG");

        btnThanhToan.setBackground(new java.awt.Color(0, 153, 0));
        btnThanhToan.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnThanhToan.setForeground(new java.awt.Color(255, 255, 255));
        btnThanhToan.setText("Thanh toán");

        javax.swing.GroupLayout pnTitleLayout = new javax.swing.GroupLayout(pnTitle);
        pnTitle.setLayout(pnTitleLayout);
        pnTitleLayout.setHorizontalGroup(
            pnTitleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnTitleLayout.createSequentialGroup()
                .addContainerGap(419, Short.MAX_VALUE)
                .addComponent(lblTitle)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 276, Short.MAX_VALUE)
                .addComponent(btnThanhToan)
                .addGap(33, 33, 33))
        );
        pnTitleLayout.setVerticalGroup(
            pnTitleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnTitleLayout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(pnTitleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblTitle, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnThanhToan))
                .addContainerGap())
        );

        pnThonhTin.setBackground(new java.awt.Color(204, 255, 204));

        lbl1.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl1.setText("Ngày:");

        lblNgay.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N

        lbl2.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl2.setText("Tên NV:");

        lblTenNV.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N

        btnKhachHang.setBackground(new java.awt.Color(230, 255, 247));
        btnKhachHang.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnKhachHang.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnKhachHangActionPerformed(evt);
            }
        });

        lbl3.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl3.setText("Tên KH:");

        lbl4.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl4.setText("SDT:");

        lbl5.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl5.setText("Địa chỉ:");

        lblGhiChu.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N

        lbl8.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl8.setText("Ghi chú:");

        lblDiaChi.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N

        lblSDT.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N

        btnAdd.setBackground(new java.awt.Color(0, 153, 0));
        btnAdd.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnAdd.setForeground(new java.awt.Color(255, 255, 255));
        btnAdd.setText("Thêm hàng");

        jPanel1.setBackground(new java.awt.Color(153, 153, 255));

        lblSoNo.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblSoNo.setText("0");

        lbl6.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lbl6.setText("Nợ cũ của khách:");

        jLabel1.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        jLabel1.setText("Tổng tên hàng:");

        jLabel2.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        jLabel2.setText("Tổng số lượng");

        jLabel3.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 0, 0));
        jLabel3.setText("Tổng cộng:");

        lblTongTenHang.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblTongTenHang.setText("0");

        lblTongSL.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblTongSL.setText("0");

        lblTongCong.setFont(new java.awt.Font("Arial", 1, 20)); // NOI18N
        lblTongCong.setForeground(new java.awt.Color(255, 0, 0));
        lblTongCong.setText("0");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(jLabel1)
                    .addComponent(jLabel3)
                    .addComponent(lbl6, javax.swing.GroupLayout.PREFERRED_SIZE, 143, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(31, 31, 31)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblTongSL, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblTongTenHang, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblSoNo, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblTongCong, javax.swing.GroupLayout.DEFAULT_SIZE, 158, Short.MAX_VALUE))
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(lblTongTenHang))
                .addGap(10, 10, 10)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(lblTongSL))
                .addGap(10, 10, 10)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lbl6)
                    .addComponent(lblSoNo))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(lblTongCong))
                .addContainerGap())
        );

        btnNew.setBackground(new java.awt.Color(0, 153, 0));
        btnNew.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        btnNew.setForeground(new java.awt.Color(255, 255, 255));
        btnNew.setText("Tạo mới HD");

        lblMaNV.setFont(new java.awt.Font("Arial", 1, 16)); // NOI18N
        lblMaNV.setForeground(new java.awt.Color(204, 255, 204));

        lblMaKhachHang.setForeground(new java.awt.Color(204, 255, 204));
        lblMaKhachHang.setText("0");

        javax.swing.GroupLayout pnThonhTinLayout = new javax.swing.GroupLayout(pnThonhTin);
        pnThonhTin.setLayout(pnThonhTinLayout);
        pnThonhTinLayout.setHorizontalGroup(
            pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnThonhTinLayout.createSequentialGroup()
                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                        .addContainerGap()
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(pnThonhTinLayout.createSequentialGroup()
                                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                                        .addComponent(lbl1, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(24, 24, 24)
                                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(lblNgay, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                            .addComponent(lblTenNV, javax.swing.GroupLayout.DEFAULT_SIZE, 192, Short.MAX_VALUE)))
                                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                                        .addComponent(btnNew)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                        .addComponent(btnAdd)))
                                .addGap(0, 0, Short.MAX_VALUE))
                            .addGroup(pnThonhTinLayout.createSequentialGroup()
                                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblMaNV, javax.swing.GroupLayout.PREFERRED_SIZE, 69, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lbl2, javax.swing.GroupLayout.PREFERRED_SIZE, 69, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnThonhTinLayout.createSequentialGroup()
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(lblMaKhachHang)
                        .addGap(76, 76, 76)))
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(20, 20, 20)
                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                        .addGap(2, 2, 2)
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(pnThonhTinLayout.createSequentialGroup()
                                .addComponent(lbl5, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(lblDiaChi, javax.swing.GroupLayout.DEFAULT_SIZE, 1, Short.MAX_VALUE))
                            .addGroup(pnThonhTinLayout.createSequentialGroup()
                                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                                        .addComponent(lbl4, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(18, 18, 18))
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnThonhTinLayout.createSequentialGroup()
                                        .addComponent(lbl8, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(7, 7, 7)))
                                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblSDT, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(lblGhiChu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))))
                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                        .addComponent(lbl3, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnKhachHang, javax.swing.GroupLayout.DEFAULT_SIZE, 194, Short.MAX_VALUE)))
                .addGap(19, 19, 19))
        );
        pnThonhTinLayout.setVerticalGroup(
            pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnThonhTinLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lbl1)
                            .addComponent(lblNgay))
                        .addGap(20, 20, 20)
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lbl2)
                            .addComponent(lblTenNV)))
                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(lbl3)
                            .addComponent(btnKhachHang, javax.swing.GroupLayout.DEFAULT_SIZE, 25, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lbl5)
                            .addComponent(lblDiaChi))))
                .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnThonhTinLayout.createSequentialGroup()
                        .addGap(10, 10, 10)
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lbl4)
                            .addComponent(lblSDT))
                        .addGap(10, 10, 10)
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblGhiChu)
                            .addComponent(lbl8))
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnThonhTinLayout.createSequentialGroup()
                        .addGap(6, 6, 6)
                        .addComponent(lblMaKhachHang)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblMaNV)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(pnThonhTinLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnNew)
                            .addComponent(btnAdd))
                        .addGap(20, 20, 20))))
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pnTable.setBackground(new java.awt.Color(255, 204, 204));

        javax.swing.GroupLayout pnTableLayout = new javax.swing.GroupLayout(pnTable);
        pnTable.setLayout(pnTableLayout);
        pnTableLayout.setHorizontalGroup(
            pnTableLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 948, Short.MAX_VALUE)
        );
        pnTableLayout.setVerticalGroup(
            pnTableLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 315, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout pnChinhLayout = new javax.swing.GroupLayout(pnChinh);
        pnChinh.setLayout(pnChinhLayout);
        pnChinhLayout.setHorizontalGroup(
            pnChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnTitle, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(pnTable, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(pnThonhTin, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        pnChinhLayout.setVerticalGroup(
            pnChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnChinhLayout.createSequentialGroup()
                .addComponent(pnTitle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(3, 3, 3)
                .addComponent(pnThonhTin, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnTable, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(pnChinh, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(0, 0, 0))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnChinh, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
    }// </editor-fold>//GEN-END:initComponents

    private void btnKhachHangActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnKhachHangActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_btnKhachHangActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAdd;
    private javax.swing.JButton btnKhachHang;
    private javax.swing.JButton btnNew;
    private javax.swing.JButton btnThanhToan;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel lbl1;
    private javax.swing.JLabel lbl2;
    private javax.swing.JLabel lbl3;
    private javax.swing.JLabel lbl4;
    private javax.swing.JLabel lbl5;
    private javax.swing.JLabel lbl6;
    private javax.swing.JLabel lbl8;
    private javax.swing.JLabel lblDiaChi;
    private javax.swing.JLabel lblGhiChu;
    private javax.swing.JLabel lblMaKhachHang;
    private javax.swing.JLabel lblMaNV;
    private javax.swing.JLabel lblNgay;
    private javax.swing.JLabel lblSDT;
    private javax.swing.JLabel lblSoNo;
    private javax.swing.JLabel lblTenNV;
    private javax.swing.JLabel lblTitle;
    private javax.swing.JLabel lblTongCong;
    private javax.swing.JLabel lblTongSL;
    private javax.swing.JLabel lblTongTenHang;
    private javax.swing.JPanel pnChinh;
    private javax.swing.JPanel pnTable;
    private javax.swing.JPanel pnThonhTin;
    private javax.swing.JPanel pnTitle;
    // End of variables declaration//GEN-END:variables
}
