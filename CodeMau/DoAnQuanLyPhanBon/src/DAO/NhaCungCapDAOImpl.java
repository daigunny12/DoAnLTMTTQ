
package DAO;

import java.util.List;
import Object.NhaCungCapObj;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Connection;
import java.util.ArrayList;

public class NhaCungCapDAOImpl implements NhaCungCapDAO{

    @Override
    public List<NhaCungCapObj> getList() {
       List<NhaCungCapObj> list = new ArrayList<NhaCungCapObj>() ;
       Connection conn = KetNoiCSDL.KetNoiCSDL();
       String sql = "select * from NhaCungCap where TinhTrang = 'True'";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                NhaCungCapObj ncc = new NhaCungCapObj();
                ncc.setMaNCC(rs.getInt("MaNCC"));
                ncc.setTenNCC(rs.getString("TenNCC"));
                ncc.setDiaChi(rs.getString("DiaChi"));
                ncc.setSdt(rs.getString("SDT"));
                ncc.setSoNo(rs.getInt("SoNo"));
                ncc.setGhiChu(rs.getString("GhiChu"));
                
                list.add(ncc);
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
    public boolean UpdateTable(NhaCungCapObj nhaCungCapObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql ="update NhaCungCap set TenNCC =?, DiaChi=?, SDT =?, SoNo =?, GhiChu =? , TinhTrang = 'True' where MaNCC =?" ;
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nhaCungCapObj.getTenNCC());
            ps.setString(2, nhaCungCapObj.getDiaChi());
            ps.setString(3, nhaCungCapObj.getSdt());
            ps.setFloat(4, nhaCungCapObj.getSoNo());
            ps.setString(5, nhaCungCapObj.getGhiChu());
            ps.setInt(6, nhaCungCapObj.getMaNCC());
            
            return ps.executeUpdate() >=0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean AddTable(NhaCungCapObj nhaCungCapObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql ="insert into NhaCungCap(TenNCC,DiaChi,SDT,SoNo,GhiChu,TinhTrang) values (?,?,?,?,?,'True')" ;
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nhaCungCapObj.getTenNCC());
            ps.setString(2, nhaCungCapObj.getDiaChi());
            ps.setString(3, nhaCungCapObj.getSdt());
            ps.setString(4, nhaCungCapObj.getSdt());
            ps.setString(5, nhaCungCapObj.getGhiChu());
            
            return ps.executeUpdate()>=0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean Delete(int Ma) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
           String sql = "UPDATE NhaCungCap SET TinhTrang= 'False' where    MaNCC=?";

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
