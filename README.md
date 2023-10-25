# IntelligentDronControl

<div align="center">
<h2>[2023] 드론 비행 제어 🎮</h2>
드론 Tello의 통신 프로토콜을 분석하여 제어 명령을 실행하는 프로젝트입니다,<br> 실시간 영상을 바탕으로 비행 경로를 스스로 결정하는 지능화 작업을 구현할 계획입니다.</div>

## 목차
  - [개요](#개요) 
  - [버전설명](#버전설명)
  - [3](#3)

## 개요

## 버전설명
- TelloTest
  - 프로젝트 환경 구축
  - Server와 Client 간의 통신

- TelloDCP ver.1
  - 드론 제어를 위한 기본적인 폼 제작
  - combobox 및 send 버튼
    - command, takeoff, land 명령어를 combox를 활용해서 제어 가능
  - 드론 조작 버튼 panel
    - takeoff(이륙), land(착륙) 버튼
    - 드론의 높이, 위치 조정하는 버튼 (추후 구현)
    - 패턴비행, 비상착륙 (추후 구현)
  - Status list box
    - 드론의 상태 신호 출력
  - Command list box
    - 드론에게 입력한 명령어 출력

- TelloDCP ver.2
  - FrmCam
    - 드론의 cam 화면을 띄워주는 창
  - MenuStrip
    - File
      - 명령어를 텍스트 형태로 저장 및 관리
    - Control
      - 드론 제어 (추후 구현)
    - Help
      - Dcp 설명 (추후 구현)
  
- TelloDCP ver.3
  - FrmFp
    - 패턴비행을 위해 드론의 경로를 생성하는 창
  
- TelloDCP ver.4

## 3
