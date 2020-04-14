
package Service;

import Object.KhachHangObj;
import java.util.List;
import DAO.KhachHangDAO;
import DAO.KhachHangDAOImpl;

public class KhachHangServiceImpl implements KhachHangService{
    public KhachHangDAO khachHangDAO = null;

    public KhachHangServiceImpl() {
        this.khachHangDAO = new KhachHangDAOImpl();
    }
    
    
    @Override
    public List<KhachHangObj> getList() {
        return khachHangDAO.getList();
    }

    @Override
    public boolean UpdateTable(KhachHangObj khachHangObj) {
        return khachHangDAO.UpdateTable(khachHangObj);
    }

    @Override
    public boolean AddTable(KhachHangObj khachHangObj) {
        return khachHangDAO.AddTable(khachHangObj);
    }

    @Override
    public boolean Delete(int Ma) {
       return khachHangDAO.Delete(Ma);
    }
    
}
