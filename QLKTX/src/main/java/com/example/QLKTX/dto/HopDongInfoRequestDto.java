package com.example.QLKTX.dto;

import com.example.QLKTX.entity.Phong;
import com.example.QLKTX.entity.SinhVien;

import java.sql.Date;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.sql.Date;

@Data
@AllArgsConstructor
@NoArgsConstructor

public class HopDongInfoRequestDto {

    private Integer hopDongId;


    private Date ngayLap;


    private Date ngayBatDauThue;


    private Date ngayKetThucThue;


    private String trangthai;


    private Integer tienthu;

    private Integer phongId;

    private Integer sinhVienId;
}
