
package DAO;

import java.util.List;
import java.sql.Connection;
import Object.KhachHangObj;
import java.util.ArrayList;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class  KhachHangDAOImpl implements KhachHangDAO{

    @Override
    public List<KhachHangObj> getList() {
       Connection conn = KetNoiCSDL.KetNoiCSDL();
       List<KhachHangObj> list = new ArrayList<KhachHangObj>();
       String sql = "select * from KhachHang where TinhTrang = 'True'";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            
            while(rs.next()){
                KhachHangObj kh = new KhachHangObj();
                kh.setMaKH(rs.getInt("MaKH"));
                kh.setTenKH(rs.getString("TenKH"));
                kh.setSdt(rs.getString("SDT"));
                kh.setDiaChi(rs.getString("DiaChi"));
                kh.setSoNo(rs.getInt("SoNo"));
                kh.setGhiChu(rs.getString("GhiChu"));
                
                list.add(kh);
            }
                 ps.close();
                rs.close();
                conn.close();
        } catch (Exception e) {
        e.printStackTrace();
        }
       
       return list;
    }

    @Override
    public boolean UpdateTable(KhachHangObj khachHangObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "update KhachHang set TenKH = ?, SDT = ?, DiaChi = ?, SoNo = ?, GhiChu = ?, TinhTrang = 'True' where MaKH = ?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, khachHangObj.getTenKH());
            ps.setString(2, khachHangObj.getSdt());
            ps.setString(3, khachHangObj.getDiaChi());
            ps.setFloat(4, khachHangObj.getSoNo());
            ps.setString(5, khachHangObj.getGhiChu());
            ps.setInt(6, khachHangObj.getMaKH());
            
            return ps.executeUpdate()>=0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean AddTable(KhachHangObj khachHangObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "insert into KhachHang(TenKH,SDT,DiaChi,SoNo,GhiChu,TinhTrang) values (?,?,?,?,?,'True')";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, khachHangObj.getTenKH());
            ps.setString(2, khachHangObj.getSdt());
            ps.setString(3, khachHangObj.getDiaChi());
            ps.setFloat(4, khachHangObj.getSoNo());
            ps.setString(5, khachHangObj.getGhiChu());
            
            return ps.executeUpdate()>=0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean Delete(int Ma) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
           String sql = "UPDATE KhachHang SET TinhTrang= 'False' where    MaKH=?";

        try {
            PreparedStatement ps = conn.prepareStatement(sql);           
            ps.setInt(1,Ma);                  
           return ps.executeUpdate()>=0;
           
        } catch (Exception e) {
            e.printStackTrace();
        }     
        return false;
    }
    
}
