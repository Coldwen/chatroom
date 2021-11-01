# chatroom

实时在线更新：https://alpine-date-98f.notion.site/91b641e332b640888c85b7dd53e60f18

## 项目

1. TCPChat 是基于C# .NET的WinForm三层架构的轻量级多线程TCP/IP通信的聊天室。

![chatroom/Main.png at main · doubleLeng/chatroom (github.com)](https://github.com/doubleLeng/chatroom/blob/main/img/img_TCPChat/Main.png)

2. UDPChat 是基于C# .NET的WinForm三层架构的UDP通信的聊天室。

![chatroom/Login.png at main · doubleLeng/chatroom (github.com)](https://github.com/doubleLeng/chatroom/blob/main/img/img_UDPChat/Login.png)

## **TCP和UDP的区别**

|              | TCP                                    | UDP                                        |
| ------------ | -------------------------------------- | ------------------------------------------ |
| 是否连接     | 面向连接                               | 无连接                                     |
| 是否可靠     | 可靠传输，使用流量控制和拥塞控制       | 不可靠传输，不使用流量控制和拥塞控制       |
| 连接对象个数 | 只能是一对一通信                       | 支持一对一，一对多，多对一和多对多交互通信 |
| 传输方式     | 面向字节流                             | 面向报文                                   |
| 首部开销     | 首部最小20字节，最大60字节             | 首部开销小，仅8字节                        |
| 适用场景     | 适用于要求可靠传输的应用，例如文件传输 | 适用于是实时应用（聊天、视频等）           |

