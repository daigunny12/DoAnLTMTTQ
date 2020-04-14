
package Model;

import javax.swing.table.DefaultTableModel;
import java.util.List;
import Object.HangHoaObj;

public class QuanLyHangHoaMod {
    public DefaultTableModel setTableHangHoa(List<HangHoaObj> listItem, String[] listColumn){
      
        DefaultTableModel dtm = new  DefaultTableModel(){
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            }   
        };
        dtm.setColumnIdentifiers(listColumn);
        int columns = listColumn.length;
        Object[] obj = null;
        int row = listItem.size();
       
        if(row>0){
            for(int i=0 ; i< row ; i++){
                HangHoaObj hh = listItem.get(i);
                obj = new Object[columns];
                obj[0] = i+1;
                obj[1] = hh.getMaHH();
                obj[2] = hh.getTeHH();
                obj[3] = hh.getDonViTinh();                
                int gbl = (int)hh.getGiaBan();
                obj[4] = gbl;
                int gm = (int)hh.getGiaMua() ;
                obj[5] = gm ;
                obj[6] = hh.getSl();
                obj[7] = hh.getGhiChu();
                
                dtm.addRow(obj);
            }
        }
        return dtm;
    }
}
