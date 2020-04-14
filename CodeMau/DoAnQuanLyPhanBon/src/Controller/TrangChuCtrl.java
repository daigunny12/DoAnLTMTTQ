
package Controller;
import Object.ThongTinCuaHangObj;
import Service.ThongTinCuaHangService;
import Service.ThongTinCuaHangServiceImpl;
import javax.swing.JLabel;

public class TrangChuCtrl {
    
    private ThongTinCuaHangService thongTinCuaHangService = null;

    public TrangChuCtrl() {
        this.thongTinCuaHangService = new ThongTinCuaHangServiceImpl();
    }
    
    public void setView(JLabel lblTenCuaHang, JLabel lblDiaChi, JLabel lblSDT){
        ThongTinCuaHangObj thongTinCuaHangObj = new ThongTinCuaHangObj();
        thongTinCuaHangObj = thongTinCuaHangService.getThongTin();
        lblTenCuaHang.setText(thongTinCuaHangObj.getTenCH());
        lblDiaChi.setText(thongTinCuaHangObj.getDiaChi());
        String phoneNumber = thongTinCuaHangObj.getSDT();
        String design = phoneNumber.substring(0, 3)+" " + phoneNumber.substring(3, 6) +" " + phoneNumber.substring(6, 10);    
        lblSDT.setText(design);
        
    }
}
