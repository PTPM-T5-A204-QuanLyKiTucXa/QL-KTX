package com.example.QLKTX.controller.resful;
import com.example.QLKTX.dto.*;
import com.example.QLKTX.entity.SinhVien;
import com.example.QLKTX.entity.SuCo;
import com.example.QLKTX.service.IHopDongThuePhongService;
import com.example.QLKTX.service.IPhongService;
import com.example.QLKTX.service.ISinhVienService;
import com.example.QLKTX.service.ISuCoService;
import org.springframework.beans.BeanUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import com.example.QLKTX.security.JwtRequestFilter;
import com.example.QLKTX.security.JwtTokenUtil;
import javax.servlet.http.HttpServletRequest;

@RestController
@CrossOrigin("*")
@RequestMapping("/api")
public class HomeRestController {

    @Autowired
    private ISinhVienService svService;

    @Autowired
    private IHopDongThuePhongService hdService;

    @Autowired
    private ISuCoService suCoService;
    @Autowired
    private IPhongService phongService;

    @Autowired
    private JwtRequestFilter jwtRequestFilter;

    @Autowired
    private JwtTokenUtil jwtTokenUtil;

    @GetMapping("/profile")
    public ResponseEntity<?> createAuthenticationToken(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVienInforRequestDto sinhvien = new SinhVienInforRequestDto();
        BeanUtils.copyProperties(svService.getSinhVienbyMaSinhVien(MaSinhVien), sinhvien);
        return ResponseEntity.ok(sinhvien);
    }

    @PutMapping ("/edit")
    public ResponseEntity<?> editInfo(@RequestBody SinhVienInforRequestDto sinhVien){
        svService.edit(sinhVien);
        return ResponseEntity.ok(HttpStatus.OK);
    }

    @GetMapping("/logout")
    public ResponseEntity<?> logout(){
        return ResponseEntity.ok(HttpStatus.OK);
    }

    @GetMapping("/contract")
    public ResponseEntity<?> gethopdong(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(MaSinhVien);
        Integer sinhVienId = sinhVien.getSinhVienId();
        HopDongInfoRequestDto hopdong = new HopDongInfoRequestDto();
        BeanUtils.copyProperties(hdService.getHopDongThuePhongbySinhVienID(sinhVienId), hopdong);

        return ResponseEntity.ok(hopdong);
    }
    @PostMapping(value = "/report")
    public ResponseEntity<?> register(@RequestBody SuCoInfoRequestDto  suCoInfoRequest){
        SuCo suCo = suCoService.report(suCoInfoRequest);
        return ResponseEntity.ok(suCo);
    }

    @GetMapping("/room")
    public ResponseEntity<?> getroom(HttpServletRequest request){
        String token = jwtRequestFilter.getJwtFromRequest(request);
        String MaSinhVien = jwtTokenUtil.getMaSinhVienFromJWT(token);
        SinhVien sinhVien = svService.getSinhVienbyMaSinhVien(MaSinhVien);
        String soPhong = sinhVien.getSoPhong();
        PhongInfoRequestDto phong = new PhongInfoRequestDto();
        BeanUtils.copyProperties(phongService.getPhongbySoPhongSinhVien(soPhong), phong);
        return ResponseEntity.ok(phong);
    }
}
