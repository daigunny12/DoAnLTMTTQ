
package DAO;

import Object.ThongKeSoHoaDonTheoNgayObj;
import java.util.List;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

public class ThongKeDAOImpl implements ThongKeDAO{

    @Override
    public List<ThongKeSoHoaDonTheoNgayObj> ThongKeHDBH() {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "select NgayLap, COUNT(*) as SL from HoaDonBanHang group by NgayLap";
        List<ThongKeSoHoaDonTheoNgayObj> list = new ArrayList<ThongKeSoHoaDonTheoNgayObj>();
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                ThongKeSoHoaDonTheoNgayObj HDBHObj = new ThongKeSoHoaDonTheoNgayObj();
                HDBHObj.setNgayLap(rs.getDate("NgayLap"));
                HDBHObj.setSL(rs.getInt("SL"));
                list.add(HDBHObj);
            }
            return list;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return  null;
    }
    
}
