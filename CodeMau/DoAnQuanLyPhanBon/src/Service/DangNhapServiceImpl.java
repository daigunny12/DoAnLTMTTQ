
package Service;

import Object.TaiKhoanObj;
import DAO.DangNhapDAO;
import DAO.DangNhapDAOImpl;

public class DangNhapServiceImpl implements DangNhapService{
    private DangNhapDAO dangNhapDAO = null;

    public DangNhapServiceImpl() {
        dangNhapDAO = new DangNhapDAOImpl();
    }
    
    
    
    @Override
    public TaiKhoanObj DangNhap(String tenDN, String matKhau) {
        return dangNhapDAO.DangNhap(tenDN, matKhau);
    }
    
}
