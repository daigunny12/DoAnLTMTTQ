
package view.Menu;
import Controller.ThongKe.ThongKeJPanelCtrl;

public class ThongKeJPanel extends javax.swing.JPanel {
 
    public ThongKeJPanel() {
        initComponents();
        
        ThongKeJPanelCtrl thongKeJPanelCtrl = new ThongKeJPanelCtrl();
        thongKeJPanelCtrl.setDateToChartl(pnThongKeSLHoaDon);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnChinh = new javax.swing.JPanel();
        pnThongKeSLHoaDon = new javax.swing.JPanel();

        pnChinh.setBackground(new java.awt.Color(230, 255, 255));

        pnThongKeSLHoaDon.setBackground(new java.awt.Color(204, 204, 255));

        javax.swing.GroupLayout pnThongKeSLHoaDonLayout = new javax.swing.GroupLayout(pnThongKeSLHoaDon);
        pnThongKeSLHoaDon.setLayout(pnThongKeSLHoaDonLayout);
        pnThongKeSLHoaDonLayout.setHorizontalGroup(
            pnThongKeSLHoaDonLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 894, Short.MAX_VALUE)
        );
        pnThongKeSLHoaDonLayout.setVerticalGroup(
            pnThongKeSLHoaDonLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 282, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout pnChinhLayout = new javax.swing.GroupLayout(pnChinh);
        pnChinh.setLayout(pnChinhLayout);
        pnChinhLayout.setHorizontalGroup(
            pnChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnThongKeSLHoaDon, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        pnChinhLayout.setVerticalGroup(
            pnChinhLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnChinhLayout.createSequentialGroup()
                .addComponent(pnThongKeSLHoaDon, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 195, Short.MAX_VALUE))
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
            .addGroup(layout.createSequentialGroup()
                .addComponent(pnChinh, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(0, 0, 0))
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel pnChinh;
    private javax.swing.JPanel pnThongKeSLHoaDon;
    // End of variables declaration//GEN-END:variables
}
