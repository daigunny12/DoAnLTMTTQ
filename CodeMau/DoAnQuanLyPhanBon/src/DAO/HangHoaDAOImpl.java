
package DAO;

import Object.HangHoaObj;
import java.util.List;
import java.sql.Connection;
import java.util.ArrayList;
import java.sql.PreparedStatement;
import java.sql.ResultSet;


public class HangHoaDAOImpl implements HangHoaDAO{

    @Override
    public List<HangHoaObj> getList() {
       Connection conn = new KetNoiCSDL().KetNoiCSDL();
       List<HangHoaObj> list = new ArrayList<HangHoaObj>();
       String sql= "select * from HangHoa where TinhTrang = 'True'";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                HangHoaObj hh = new HangHoaObj();
                hh.setMaHH(rs.getInt("MaHH"));
                hh.setTeHH(rs.getString("TenHH"));
                hh.setDonViTinh(rs.getString("DonViTinh"));
                hh.setGiaBan(rs.getFloat("GiaBan"));
                hh.setGiaMua(rs.getFloat("GiaMua"));
                hh.setSl(rs.getInt("SoLuong"));
                hh.setGhiChu(rs.getString("GhiChu"));
                
                list.add(hh);
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
    public boolean UpdateTable(HangHoaObj hangHoaObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "update HangHoa set TenHH =? , DonViTinh = ?, GiaBan = ?, GiaMua = ?, SoLuong = ?, GhiChu = ?, TinhTrang ='True' where MaHH =?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, hangHoaObj.getTeHH());
            ps.setString(2, hangHoaObj.getDonViTinh());
            ps.setFloat(3, hangHoaObj.getGiaBan());
            ps.setFloat(4, hangHoaObj.getGiaMua());
            ps.setFloat(5, hangHoaObj.getSl());
            ps.setString(6, hangHoaObj.getGhiChu());
            ps.setInt(7, hangHoaObj.getMaHH());
            
            return ps.executeUpdate()>=0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean AddTable(HangHoaObj hangHoaObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "insert into HangHoa(TenHH,DonViTinh,GiaBan,GiaMua,SoLuong,GhiChu,TinhTrang) values(?,?,?,?,?,?,'True')";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, hangHoaObj.getTeHH());
            ps.setString(2, hangHoaObj.getDonViTinh());
            ps.setFloat(3, hangHoaObj.getGiaBan());
            ps.setFloat(4, hangHoaObj.getGiaMua());
            ps.setFloat(5, hangHoaObj.getSl());
            ps.setString(6, hangHoaObj.getGhiChu());
            
            return ps.executeUpdate()>=0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }
    
    @Override
    public boolean checkSL(int MaHH , int SL){
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "select SoLuong from HangHoa where MaHH =? and SoLuong >=?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, MaHH);
            ps.setInt(2, SL);
            
            ResultSet rs = ps.executeQuery() ;
            if(rs.next()){
                return true;
            }
            else{
                return false;
            }
            
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }
    
    
    @Override
    public boolean upDateSLBanHang(int MaHH , int SL){
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "update HangHoa set SoLuong = SoLuong - ? where MaHH = ?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, SL);
            ps.setInt(2, MaHH);
            
            return  ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
       return false;
    }
    
    @Override
    public boolean upDateSLNhapHang(int MaHH , int SL){
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "update HangHoa set SoLuong = SoLuong + ? where MaHH = ?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, SL);
            ps.setInt(2, MaHH);
            
            return  ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
       return false;
    }

    @Override
    public boolean Delete(int Ma) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
           String sql = "UPDATE HangHoa SET TinhTrang= 'False' where    MaHH=?";

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
