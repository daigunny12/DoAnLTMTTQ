
package Service;

import Object.ThongTinCuaHangObj;
import DAO.ThongTinCuaHangDAO;
import DAO.ThongTinCuaHangDAOImpl;

public class ThongTinCuaHangServiceImpl implements ThongTinCuaHangService{
    private ThongTinCuaHangDAO thongTinCuaHangDAO = null;

    public ThongTinCuaHangServiceImpl() {
        this.thongTinCuaHangDAO = new ThongTinCuaHangDAOImpl();
    }
    
    
    @Override
    public ThongTinCuaHangObj getThongTin() {
        return thongTinCuaHangDAO.getThongTin();
    }
    
}
