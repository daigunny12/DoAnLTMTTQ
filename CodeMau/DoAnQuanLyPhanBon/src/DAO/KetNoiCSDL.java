package DAO;

import java.sql.Connection;
import java.sql.DriverManager;

public class KetNoiCSDL {

    public static Connection KetNoiCSDL(){
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
           Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:8181;databasename=QuanLyCuaHangPhanBon;username=sa;password=sa");
           return conn;
        }catch (Exception e){
             return null;
        }   
    }
}
