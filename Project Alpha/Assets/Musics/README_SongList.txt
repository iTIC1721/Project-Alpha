SongList.txt파일은 각 줄마다 하나의 음악팩/음악의 정보를 담는다.
각각의 줄에서는 쉼표로 정보를 구분한다.

첫 숫자가 0이면 음악팩을 뜻한다.
두번째 정보는 음악팩의 인덱스를 나타낸다. 음악팩은 게임 내에서 인덱스 순서대로 보여진다.
세번째 정보는 음악팩의 이름을 나타낸다.
네번째 정보는 음악팩의 일러스트 경로를 나타낸다.
다섯번째 정보가 0이면 음악팩을 선택 가능함을 나타낸다. 1이면 아직 열리지 않았음을 나타낸다. 2이면 결제를 통해 구입할 수 있음을 나타낸다.

첫 숫자가 1이면 음악을 뜻한다.
두번째 정보는 음악이 들어있는 음악팩의 인덱스를 나타낸다.
세번째 정보는 음악의 인덱스를 나타낸다. 음악은 게임 내에서 인덱스 순서대로 보여진다.
네번째 정보는 음악의 제목을 나타낸다.
다섯번째 정보는 음악의 작곡가를 나타낸다.
여섯번째 정보는 음악의 일러스트 경로를 나타낸다. (Resources 폴더 내에 위치)
일곱번째 정보는 음악의 Easy 난이도의 레벨을 나타낸다.
여덟번째 정보는 음악의 Normal 난이도의 레벨을 나타낸다.
아홉번째 정보는 음악의 Hard 난이도의 레벨을 나타낸다.
열번째 정보는 음악의 Special 난이도의 레벨을 나타낸다. Special 난이도가 존재하지 않는다면 "."으로 작성한다.
열한번째 정보가 0이면 음악의 일반 레벨(Special 제외)이 선택 가능함을 나타낸다. 1이면 아직 열리지 않았음을 나타낸다. 2이면 결제를 통해 구입할 수 있음을 나타낸다.
열두번째 정보가 0이면 음악의 Special 난이도가 선택 가능함을 나타낸다. 1이면 아직 열리지 않았음을 의미한다.

+ 음악팩과 음악의 인덱스는 0부터 중간에 빠진 숫자 없이 순서대로 입력하도록 한다.

+ 없는 정보는 작성하지 않고 비워둔다.

+ 난이도별 채보 파일의 이름은 "곡제목_난이도"로 작성한다.