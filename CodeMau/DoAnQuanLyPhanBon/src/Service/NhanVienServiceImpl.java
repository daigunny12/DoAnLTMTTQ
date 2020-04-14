/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Service;

import Object.NhanVienObj;
import java.util.List;
import DAO.NhanVienDAOImpl;
import DAO.NhanVienDAO;


public class NhanVienServiceImpl implements NhanVienService{

    private NhanVienDAO nhanVienDAO  = null;
            
    public NhanVienServiceImpl(){
        this.nhanVienDAO = new NhanVienDAOImpl();
    }
    @Override
    public List<NhanVienObj> getList(){
       return nhanVienDAO.getList();
    }

    @Override
    public boolean UpdateTable(NhanVienObj nhanVienObj) {
        return nhanVienDAO.UpdateTable(nhanVienObj);
    }

    @Override
    public boolean AddTable(NhanVienObj nhanVienObj) {
        return nhanVienDAO.AddTable(nhanVienObj);
    }

    @Override
    public boolean DeleteNV(int Ma) {
        return nhanVienDAO.DeleteNV(Ma);
    }
    
}
