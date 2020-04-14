
package Model;
import Object.NhaCungCapObj;
import javax.swing.table.DefaultTableModel;
import java.util.List;

public class QuanLyNhaCungCapMod {
    public DefaultTableModel getTableNhaCungCap(List<NhaCungCapObj> listItem ,String[] listColumn){
        DefaultTableModel dtm = new DefaultTableModel(){
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
            } 
        };
        dtm.setColumnIdentifiers(listColumn);
        int row = listItem.size();
        int columns = listColumn.length;
        Object[] obj = new Object[columns];
        
        if(row >0){
            for(int i = 0 ; i< row ; i++){
                NhaCungCapObj ncc = listItem.get(i);
                obj = new Object[columns];
                
                obj[0] = i+1;
                obj[1] = ncc.getMaNCC();
                obj[2] = ncc.getTenNCC();
                obj[3] = ncc.getDiaChi();
                obj[4] = ncc.getSdt();
                int sn = (int)ncc.getSoNo();
                obj[5] = sn ;
                obj[6] = ncc.getGhiChu();
                
                dtm.addRow(obj);
            }
        }
        return dtm;
    }
}
