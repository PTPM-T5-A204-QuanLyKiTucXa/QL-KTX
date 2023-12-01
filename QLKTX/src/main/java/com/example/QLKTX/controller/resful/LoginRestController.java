package com.example.QLKTX.controller.resful;
import com.example.QLKTX.dto.RegisterRequestDto;
import com.example.QLKTX.dto.LoginRequestDto;
import com.example.QLKTX.entity.NguoiDung;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.security.JwtTokenUtil;
import com.example.QLKTX.service.INguoiDungService;
import com.example.QLKTX.service.ISinhVienService;
import com.example.QLKTX.dto.JwtResponse;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@CrossOrigin("*")
@RequestMapping("/api")
public class LoginRestController {

    @Autowired
    private ISinhVienService svService;

    @Autowired
    private INguoiDungService nguoiDungService;

    @Autowired
    private JwtTokenUtil jwtTokenUtil;

    @PostMapping(value = "/register")
    public ResponseEntity<?> register(@RequestBody RegisterRequestDto registerRequest){
        SinhVien sv = svService.register(registerRequest);
        return ResponseEntity.ok(sv);
    }


    @PostMapping(value = "/login")
    public ResponseEntity<?> createAuthenticationToken(@RequestBody LoginRequestDto authenticationRequest){
        String token = svService.login(authenticationRequest);
        String username = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(username);
        NguoiDung nguoidung = nguoiDungService.getNguoiDungByTenNguoiDung(username);
        String trangthai =sinhVien.getTrangThai();
        Integer vaitro = nguoidung.getVaiTroId();
        String role="";
        if (trangthai.equals("Chờ duyệt"))
        {
            return  ResponseEntity.ok("Đang chờ duyệt");
        }
        if (trangthai.equals("Đang ở")||trangthai.equals("Đã duyệt"))
        {
            if (vaitro ==1)
            {
                role="ROLE_ADMIN";
            }
            if (vaitro ==2)
            {
                role="ROLE_USER";
            }
        }
        return ResponseEntity.ok(new JwtResponse(token,role));
    }

}
