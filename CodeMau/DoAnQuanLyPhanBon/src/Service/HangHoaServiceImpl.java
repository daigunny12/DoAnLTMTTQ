
package Service;

import Object.HangHoaObj;
import java.util.List;
import DAO.HangHoaDAO;
import DAO.HangHoaDAOImpl;


public class HangHoaServiceImpl implements HangHoaService{

    private HangHoaDAO hangHoaDAO = null;

    public HangHoaServiceImpl() {
        this.hangHoaDAO = new HangHoaDAOImpl();
    }
    
    
    @Override
    public List<HangHoaObj> getList() {
       return  hangHoaDAO.getList();
    }

    @Override
    public boolean UpdateTable(HangHoaObj hangHoaObj) {
        return hangHoaDAO.UpdateTable(hangHoaObj);
    }

    @Override
    public boolean AddTable(HangHoaObj hangHoaObj) {
        return hangHoaDAO.AddTable(hangHoaObj);
    }

    @Override
    public boolean checkSL(int MaHH, int SL) {
        return hangHoaDAO.checkSL(MaHH, SL);
    }

    @Override
    public boolean upDateSLBanHang(int MaHH, int SL) {
         return hangHoaDAO.upDateSLBanHang(MaHH, SL);
    }

    @Override
    public boolean upDateSLNhapHang(int MaHH, int SL) {
        return hangHoaDAO.upDateSLNhapHang(MaHH, SL);
    }

    @Override
    public boolean Delete(int Ma) {
        return hangHoaDAO.Delete(Ma);
    }
    
}
