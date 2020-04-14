package Controller.ThongKe;

import Object.ThongKeSoHoaDonTheoNgayObj;
import Service.ThongKeService;
import Service.ThongKeServiceImpl;
import java.awt.CardLayout;
import java.awt.Dimension;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JPanel;
import java.util.List;
import org.jfree.chart.ChartFactory;
import org.jfree.chart.ChartPanel;
import org.jfree.chart.JFreeChart;
import org.jfree.data.category.DefaultCategoryDataset;

public class ThongKeJPanelCtrl {

    private ThongKeService thongKeService = null;
    
    public ThongKeJPanelCtrl() {
        this.thongKeService = new ThongKeServiceImpl();
    }

    public void setDateToChartl(JPanel jpnItem) {
        List<ThongKeSoHoaDonTheoNgayObj> listItem = thongKeService.ThongKeHDBH();
        if (listItem != null) {
            DefaultCategoryDataset dataSet = new DefaultCategoryDataset();
            for (ThongKeSoHoaDonTheoNgayObj item : listItem) {
                String ngay;
                Date date = item.getNgayLap();
                SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
                String strDate = formatter.format(date);
                dataSet.addValue(item.getSL(), "Số đơn hàng",strDate);
            }
            JFreeChart chart = ChartFactory.createBarChart("THỐNG KÊ SỐ LƯỢNG HÓA ĐƠN", "THỜI GIAN", "SỐ LƯỢNG", dataSet);

            ChartPanel chartPanel = new ChartPanel(chart);
            
            chartPanel.setPreferredSize(new Dimension(jpnItem.getWidth(), 300));

            jpnItem.removeAll();
            jpnItem.setLayout(new CardLayout());
            jpnItem.add(chartPanel);
            jpnItem.validate();
            jpnItem.repaint();
        }

    }

}
