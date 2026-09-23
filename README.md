## Unity TeamProject GroundRule

### 개발 가이드

#### 저장소 주소
[https://github.com/swchoi-dev/PracticeTeamProject](https://github.com/swchoi-dev/PracticeTeamProject)

#### 브랜치 가이드
- main : 게임의 빌드를 생성할 운영 브랜치입니다. 모든 **신규브랜치는 여기서 생성**합니다. **PR을 통해 머지를 합니다**
- 개인 브랜치 : 깃헙 이슈페이지에서 Create Branch 버튼을 통해 만들고 prod 브랜치로부터 생성합니다. 브랜치 명은 **feature_swchoi_issueTitle** 으로 정합니다.


#### 작업흐름
1. [업무목록](https://github.com/users/swchoi-dev/projects/1/views/2)에서 본인에게 할당된 업무목록을 확인합니다.
2. Todo에서 In Progress 칸으로 작업을 옮깁니다.
<img width="982" height="676" alt="녹음 2026-09-22 125317" src="https://github.com/user-attachments/assets/1274b441-6804-4fef-a5ba-612004032763" />

3. 업무량을 고려해 해당 업무의 시작 날짜와 종료 날짜를 스스로 입력합니다.<img width="831" height="467" alt="image" src="https://github.com/user-attachments/assets/2ab6553d-507a-4bf0-bd36-1fdc86244abf" />

4. 브랜치를 생성하고 작업을 진행합니다.
5. 개인 브랜치에서 테스트를 하고 문제가 없다면 Done 칸으로 옮기고 PR을 생성합니다.

#### 커밋 가이드
- feat : 기능 추가, 변경, 삭제 등 개발에 대한 전반적인 내용
- fix : QA 진행 중 발견한 **버그**를 수정했을 때
- docs : 문서작업을 했을 때
- chore : 코드컨벤션 맞춤, 기타 작업 시

#### 커밋 메시지 가이드

#### 코딩 컨벤션
강사님께서 작성해주신 그라운드룰을 사용합니다.
[코딩컨벤션](https://github.com/swchoi-dev/PracticeTeamProject/blob/prod/Docs/CSharpConvention.md)

### 역할·일정 (예시)
#### 역할
- 최성원 : 프로젝트 구조 설정, 개발 환경 준비, 업무 분배, Ground Monster 개발
- 노승훈 : 프로젝트 형상관리, 일정 관리, Player 개발
- 이준빈 : 게임 메인 로직 개발, UI 개발, Fly Monster 개발
- 강성현 : 게임 전투 로직 개발, Game Scene 구성, Weapon, Attack 개발
  
#### 일정
- [업무목록](https://github.com/users/swchoi-dev/projects/1/views/2)
- [개발일정](https://github.com/users/swchoi-dev/projects/1/views/3)

### 작업 폴더 구조
```text
Assets
    ├─_Project
        ├─ Prefabs
        ├─ Scenes
            ├─ Game
            ├─ swchoi
            ├─ jblee
            ├─ shroh
            └─ shKang
        └─ Scripts
            ├─ Interface
            ├─ Untility
            ├─ Manager
            ├─ Monster
            ├─ Turret
            └─ Player
        ├─ Etc
            ├─ Font
            ├─ Sound
            └─ Images
    └─ Imports (Asset Store에서 받은 것들)
```

### 씬·프리팹 작업
#### 씬
- `Scene` : `본인의이름` 폴더에 Scene을 만들어서 개발합니다.
- `Game` : 실제 게임에서 사용될 Scene들이 포함됩니다.

#### 프리팹
본인이 생성하지 않은 Prefab이 필요한경우 **절대 `override`를 하지 않습니다.**
개발에 필요한 경우 Prefab을 복사하거나 **Variants**를 만들어서 씁니다.
