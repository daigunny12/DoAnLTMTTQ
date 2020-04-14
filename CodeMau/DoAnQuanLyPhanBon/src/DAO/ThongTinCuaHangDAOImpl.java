
package DAO;

import Object.ThongTinCuaHangObj;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class ThongTinCuaHangDAOImpl implements ThongTinCuaHangDAO{

    @Override
    public ThongTinCuaHangObj getThongTin() {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "select * from ThongTinCuaHang";
        
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            ThongTinCuaHangObj thongTinCuaHangObj = new ThongTinCuaHangObj();
            if(rs.next()){
                thongTinCuaHangObj.setTenCH(rs.getString("TenCuaHang"));
                thongTinCuaHangObj.setDiaChi(rs.getString("DiaChi"));
                thongTinCuaHangObj.setSDT(rs.getString("SDT"));
            }
            return thongTinCuaHangObj;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
    
}
