package com.example.QLKTX.dto;

import com.example.QLKTX.entity.LoaiPhong;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Data
@AllArgsConstructor
@NoArgsConstructor
public class PhongInfoRequestDto {
    private Integer phongId;

    private String soPhong;

    private Integer tang;

    private String trangThai;

    private Integer loaiPhong;
}
