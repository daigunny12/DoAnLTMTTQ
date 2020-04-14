
package Service;

import Object.ThongKeSoHoaDonTheoNgayObj;
import java.util.List;
import DAO.ThongKeDAO;
import DAO.ThongKeDAOImpl;

public class ThongKeServiceImpl implements ThongKeService{

    private ThongKeDAO thongKeDAO = null;

    public ThongKeServiceImpl() {
        this.thongKeDAO = new ThongKeDAOImpl();
    }
    
    @Override
    public List<ThongKeSoHoaDonTheoNgayObj> ThongKeHDBH() {
        return thongKeDAO.ThongKeHDBH();
    }
    
}
