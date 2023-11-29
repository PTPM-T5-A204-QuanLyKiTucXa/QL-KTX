package com.example.QLKTX.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "loaiphong")
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Builder
public class LoaiPhong {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "loai_phong_id")
    private Integer loaiPhongId;

    @Column(name = "ten_loai_phong")
    private String tenLoaiPhong;

    @Column(name = "gia_phong")
    private Double giaPhong;

    @Column(name = "so_nguoi_toi_da")
    private Integer soNguoiToiDa;

    @OneToMany(mappedBy = "loaiPhong",targetEntity = Phong.class)
    private Set<Phong> phongs = new HashSet<>();

}
