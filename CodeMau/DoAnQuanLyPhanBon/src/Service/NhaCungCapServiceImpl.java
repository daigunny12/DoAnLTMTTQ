
package Service;

import Object.NhaCungCapObj;
import java.util.List;
import DAO.NhaCungCapDAO;
import DAO.NhaCungCapDAOImpl;


public class NhaCungCapServiceImpl implements NhaCungCapService{
    public NhaCungCapDAO nhaCungCapDAO = null;

    public NhaCungCapServiceImpl() {
        this.nhaCungCapDAO =new  NhaCungCapDAOImpl();
    }
    
    
    @Override
    public List<NhaCungCapObj> getList() {
        return nhaCungCapDAO.getList();
    }

    @Override
    public boolean UpdateTable(NhaCungCapObj nhaCungCapObj) {
        return nhaCungCapDAO.UpdateTable(nhaCungCapObj);
    }

    @Override
    public boolean AddTable(NhaCungCapObj nhaCungCapObj) {
        return nhaCungCapDAO.AddTable(nhaCungCapObj);
    }

    @Override
    public boolean Delete(int Ma) {
        return nhaCungCapDAO.Delete(Ma);
    }
    
}
