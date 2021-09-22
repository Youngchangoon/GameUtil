# GameUtil

유니티 개발에 필요한 유틸리티, 패턴 그리고 확장 함수들을 가지고 있는 라이브러리 입니다.


## Features

- Extensions: C#과 유니티 객체의 유용한 확장 함수들 입니다.
- ObjectPool: GameObject객체 풀링을 지원하는 Generic 객체입니다.
- GenericDictionary: 유니티 내의 Dictionary를 지원하는 Generic 객체입니다.
- Random
  - Mersenne: 다양한 디바이스에 영향없이 항상 동일한 시드에서 동일한 값을 뽑아내는 랜덤 객체입니다.
- Singleton: 단일성을 유지하는 싱글톤 패턴입니다. (Mono/C#)
- Utils: 개발하면서 유용했던 함수들을 모아둔 static 객체입니다.

## Install

- `Packages/manifest.json` 파일에 접근합니다.
- 아래와 같이 scopedRegistries를 추가하고 npm을 추가합니다.
- dependencies에 `"longman.gameutil": "X.Y.Z"`을 추가합니다.

```
{
  "scopedRegistries": [
    {
      "name": "npmjs",
      "url": "https://registry.npmjs.org/",
      "scopes": [
        "longman"
      ]
    }
  ],

  "dependencies": {
    "longman.gameutil": "1.0.0"
  }
}
```