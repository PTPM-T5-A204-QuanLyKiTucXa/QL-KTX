package com.example.QLKTX.service.impl;

import com.example.QLKTX.dto.LoginRequestDto;
import com.example.QLKTX.dto.RegisterRequestDto;
import com.example.QLKTX.dto.SinhVienInforRequestDto;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.repository.ISinhVienRepository;
import com.example.QLKTX.service.ISinhVienService;
import com.example.QLKTX.security.JwtTokenUtil;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.AuthenticationServiceException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
@RequiredArgsConstructor
public class SinhVienService implements ISinhVienService {
    @Autowired
    private final ISinhVienRepository repository;
    @Autowired
    private PasswordEncoder passwordEncoder;
    @Autowired
    private JwtTokenUtil jwtTokenUtil;

    @Override
    public void save(SinhVien sinhVien) {
        repository.save(sinhVien);
    }
    @Override
    @Transactional
    public SinhVien register(RegisterRequestDto registerRequest) {
       String password = registerRequest.getSoDienThoai();
       //String cypherText = passwordEncoder.encode(password);
        SinhVien sv = new SinhVien();
        sv.setMaSinhVien(registerRequest.getMaSinhVien());
       // sv.setSoDienThoai(cypherText);
        sv.setHoTen(registerRequest.getHoTen());
        sv.setNgaySinh(registerRequest.getNgaySinh());
        sv.setCccd(registerRequest.getCccd());
        sv.setGioiTinh(registerRequest.getGioiTinh());
        sv.setSoDienThoai(password);
        sv.setDiaChi(registerRequest.getDiaChi());
        sv.setEmail(registerRequest.getEmail());
        sv.setTrangThai(registerRequest.getTrangThai());
        sv.setSoPhong(registerRequest.getSoPhong());
        sv.setNguoiDung(registerRequest.getNguoiDung());
        repository.save(sv);
        return sv;
    }
    @Override
    public String login(LoginRequestDto authenticationRequest) {
        SinhVien sv = repository.findByMaSinhVien(authenticationRequest.getUsername());

        if(!authenticationRequest.getPassword().equals(sv.getSoDienThoai())){
            throw new AuthenticationServiceException("Wrong password");
        }
        return jwtTokenUtil.generateToken(sv);

    }
    @Override
    public  SinhVien getSinhVienbyMaSinhVien(String MaSinhVien)
    {return repository.findSinhVienByMaSinhVien(MaSinhVien);}

    @Override
    @Transactional
    public void edit(SinhVienInforRequestDto sinhVien) {

        SinhVien svs =repository.findBySinhVienId(sinhVien.getSinhVienId());

        svs.setMaSinhVien(sinhVien.getMaSinhVien());
        svs.setHoTen(sinhVien.getHoTen());
        svs.setNgaySinh(sinhVien.getNgaySinh());
        svs.setCccd(sinhVien.getCccd());
        svs.setGioiTinh(sinhVien.getGioiTinh());
        svs.setSoDienThoai(sinhVien.getSoDienThoai());
        svs.setDiaChi(sinhVien.getDiaChi());
        svs.setEmail(sinhVien.getEmail());
        svs.setTrangThai(sinhVien.getTrangThai());
        svs.setSoPhong(sinhVien.getSoPhong());
        svs.setNguoiDung(sinhVien.getNguoiDung());
        repository.save(svs);

    }

    @Override
    public List<SinhVien> getAll() {
        return repository.findAll();
    }
}
