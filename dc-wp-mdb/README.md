# Blog site
- WordPress
- docker-compose.ymldocker-compose.ymlMariaDB

|      | MariaDB コンテナ     | WordPress コンテナ  |
|-----------------|-------------------|--------------------|
| Dockerイメージ         | mariadb:latest    | wordpress:latest   |
| データ保管用ディレクトリ | /data/mysql       | /data/html         |
| IPアドレス        | 172.20.0.3        | 172.20.0.2         |
| コンテナ用ネットワーク  | mynet (172.20.0.0/24) | mynet (172.20.0.0/24) |
| 公開するポート番号   | 3306              | 8000:80            |
| Docker Composeにおけるサービス名 | db                | wordpress          |

コンテナ起動
```bash
docker compose -f .\docker-compose.yml up -d
```