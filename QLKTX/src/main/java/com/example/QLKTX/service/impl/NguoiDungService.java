package com.example.QLKTX.service.impl;

import com.example.QLKTX.entity.NguoiDung;
import com.example.QLKTX.repository.INguoiDungRepository;
import com.example.QLKTX.service.INguoiDungService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class NguoiDungService implements INguoiDungService {

    @Autowired
    INguoiDungRepository nguoiDungRepository;

    @Override
    public NguoiDung getNguoiDungByTenNguoiDung(String TenNguoiDung) {
        return  nguoiDungRepository.findByTenNguoiDung(TenNguoiDung);
    }

}
