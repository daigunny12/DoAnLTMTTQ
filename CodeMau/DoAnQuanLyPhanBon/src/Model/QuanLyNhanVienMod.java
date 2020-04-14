
package Model;

import java.util.List;
import javax.swing.table.DefaultTableModel;
import Object.NhanVienObj;
import java.text.SimpleDateFormat;
import java.util.Date;

public class QuanLyNhanVienMod {
    public DefaultTableModel setTableNhanVien(List<NhanVienObj> listItem, String[] listColumn){
        DefaultTableModel dtm = new DefaultTableModel(){
            @Override
            public boolean isCellEditable(int row, int column) {
                return false;
         }   
        };
        dtm.setColumnIdentifiers(listColumn);
        int columns = listColumn.length;
        Object[] obj = null;
        int row = listItem.size();
        if(row >0 ){
            for(int i = 0 ; i<row ; i++){
                NhanVienObj nhanvien = listItem.get(i);
                obj = new Object[columns];
                obj[0] = nhanvien.getMaNV();
                obj[1] = i+1;
                obj[2] = nhanvien.getTenNV();
                obj[3] = nhanvien.getGioiTinh();
                Date date =nhanvien.getNgaySinh();
                SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
                String strDate = formatter.format(date);
                obj[4] = strDate;
                obj[5] = nhanvien.getDiaChi();
                obj[6] = nhanvien.getSdt();
                obj[7] = nhanvien.getGhiChu();
                
                dtm.addRow(obj);
            }
        }
        return dtm;
    }
}
