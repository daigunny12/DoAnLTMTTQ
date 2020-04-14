package DAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import Object.NhanVienObj;
import java.sql.Date;
import java.util.List;
import java.util.ArrayList;


public class NhanVienDAOImpl implements NhanVienDAO{

   
    @Override
    public List<NhanVienObj> getList() {
        Connection  conn = KetNoiCSDL.KetNoiCSDL();
        List<NhanVienObj> list = new ArrayList<NhanVienObj>();
        String sql = "select *from NhanVien where TinhTrang = 'True'";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                NhanVienObj nv = new NhanVienObj();
                nv.setMaNV(rs.getInt("MaNV"));
                nv.setTenNV(rs.getString("TenNV"));
                nv.setGioiTinh(rs.getString("GioiTinh"));
                nv.setNgaySinh(rs.getDate("NgaySinh"));
                nv.setDiaChi(rs.getString("DiaChi"));
                nv.setSdt(rs.getString("SDT"));
                nv.setGhiChu(rs.getString("GhiChu"));
                
               
                list.add(nv);
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
    public boolean UpdateTable(NhanVienObj nhanVienObj) {
           Connection conn = KetNoiCSDL.KetNoiCSDL();
           String sql = "UPDATE NhanVien SET TenNV=?, GioiTinh =?, NgaySinh =?, DiaChi =?, SDT =? , GhiChu =?  where    MaNV=?";

        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            
            ps.setString(1,nhanVienObj.getTenNV());
            ps.setString(2, nhanVienObj.getGioiTinh());
            ps.setDate(3, new Date(nhanVienObj.getNgaySinh().getTime()));
            ps.setString(4, nhanVienObj.getDiaChi());
            ps.setString(5,nhanVienObj.getSdt());
            ps.setString(6, nhanVienObj.getGhiChu());
            ps.setInt(7, nhanVienObj.getMaNV());
            
           return ps.executeUpdate()>=0;
           
        } catch (Exception e) {
            e.printStackTrace();
        }     
        return false;
    }

    @Override
    public boolean AddTable(NhanVienObj nhanVienObj) {
Connection conn = KetNoiCSDL.KetNoiCSDL();
           String sql = "INSERT INTO NhanVien(TenNV, GioiTinh, NgaySinh,DiaChi,SDT,GhiChu,TinhTrang) VALUES (?,?,?,?,?,?,'True')";

        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            
            ps.setString(1,nhanVienObj.getTenNV());
            ps.setString(2, nhanVienObj.getGioiTinh());
            ps.setDate(3, new Date(nhanVienObj.getNgaySinh().getTime()));
            ps.setString(4, nhanVienObj.getDiaChi());
            ps.setString(5,nhanVienObj.getSdt());
            ps.setString(6, nhanVienObj.getGhiChu());
            
           return ps.executeUpdate()>=0;
           
        } catch (Exception e) {
            e.printStackTrace();
        }     
        return false;
    }

    @Override
    public boolean DeleteNV(int Ma) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
           String sql = "UPDATE NhanVien SET TinhTrang= 'False' where    MaNV=?";

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
