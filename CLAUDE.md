# FirstProject — Unity 면접 준비 포트폴리오

## 프로젝트 목적
유니티 취업 면접을 위한 기술 포트폴리오 프로젝트.
아래 기술들을 **하나씩 단계적으로** 적용하며 이해하는 것이 목표.

## 장르
**3D 웨이브 서바이벌 (탑다운)**

## 학습 및 구현 순서

### 1단계 — OOP 기초
- Interface & Abstract Class (Entity 기반 구조 설계)
- Overloading & Overriding (Player, Enemy 구체화)
- Update 순서 이해 (FixedUpdate: 물리, LateUpdate: 카메라)

### 2단계 — 구조 설계
- SOLID 원칙 적용하며 클래스 설계
- Singleton 패턴 (GameManager, AudioManager)
- ScriptableObject (적/아이템/웨이브 데이터 분리)

### 3단계 — 디자인 패턴
- Observer 패턴 (점수, HP, 웨이브 이벤트)
- State 패턴 (적 AI: Idle → Chase → Attack → Die)

### 4단계 — 최적화
- Coroutine (좋은 예 / 나쁜 예 비교 포함)
- Object Pooling (총알, 이펙트)
- Atlas & Draw Call 최적화
- LOD 설정

### 5단계 — 에셋 관리
- Addressables (웨이브별 동적 에셋 로딩)

## 협업 지침
- 한 단계씩 완료 후 다음 단계로 넘어간다.
- 각 기술은 실제 게임 기능에 자연스럽게 녹아들도록 구현한다.
- 면접 설명을 위해 각 기술의 "왜 썼는가"를 코드나 커밋 메시지에 남긴다.
