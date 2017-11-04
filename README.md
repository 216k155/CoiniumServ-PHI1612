CoiniumServ mining pool will keep developing by Luxcore dev.
 
**CoiniumServ** is a high performance, extremely efficient, platform-agnostic, easy to setup pool server implementation. It features stratum and vanilla services, reward, payment, share processors, vardiff & ban managers, user-friendly embedded web-server & front-end and a full-stack API.

### Screenshots

##### Console

![CoiniumServ running over mono & ubuntu](http://i.imgur.com/HvaPVrZ.png)

##### Embedded web frontend

![Embedded web frontend](http://i.imgur.com/oOF8lQ0.png)

### Status

Latest release: [v1.0.0](https://github.com/216k155/CoiniumServ-PHI1612/releases/tag/V1.0)

### Getting Started

Start by checking our [Getting Started](https://github.com/bonesoul/CoiniumServ/wiki/Getting-Started) guide for installation instructions for *nix and Windows.

### Features
* __Platform Agnostic__; unlike other pool-servers, CoiniumServ doesn't dictate platforms and can run on anything including Windows, Linux or MacOS.
* __High Performance__; Designed to be fast & efficient, CoiniumServ can handle dozens of pools together.
* __Modular & Flexible__; Designed to be modular since day one so that you can implement your very own ideas.
* __Free & Open-Source__; Best of all CoiniumServ is open source and free-to-use. You can get it running for free in minutes.
* __Easy to Setup__; We got your back covered with our [guides & how-to's](https://github.com/bonesoul/CoiniumServ/wiki).

##### General

* Multiple pools & ports
* Multiple coin daemon connections
* Supports POW (proof-of-work) coins
* Supports POS (proof-of-stake) coins

##### Algorithms
PHI, __Scrypt__, __SHA256d__, __X11__, __X13__, X14, X15, X17, Blake, Fresh, Fugue, Groestl, Keccak, NIST5, Scrypt-OG, Scrypt-N, SHA1, SHAvite3, Skein, Qubit

##### Protocols

* Stratum
 * show_message support
 * block template support
 * generation transaction support
 * transaction message (txMessage) support
* Getwork [experimental]

##### Storage Layers

* Hybrid mode (redis + mysql)
* [MPOS](https://github.com/MPOS/php-mpos) compatibility (mysql)

##### Embedded Web Server

* Customizable front-end
* Full stack json-api

##### Addititional Features

* ✔ Vardiff support
* ✔ Ban manager (that can handle miners flooding with invalid shares)
* ✔ Share & Payment processor, Job Manager


