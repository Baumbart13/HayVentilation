# Hay ventilation

<br/>
<p align="center">
  <a href="https://github.com/Baumbart13">
    <img src="https://avatars.githubusercontent.com/u/46692947" alt="Logo" width="200" height="200">
  </a>

<h3 align="center">Hay ventilation</h3>

<p align="center">
    A small program, which runs on a Raspberry, that control a hay ventilation and offers a webinterface made with flask 
    <br/>
    <a href="https://github.com/Baumbart13/HayVentilation/releases">Releases</a>
    ·
    <a href="https://github.com/Baumbart13/HayVentilation/issues">Report Bug</a>
    ·
    <a href="https://github.com/Baumbart13/HayVentilation/issues">Request Feature</a>
  </p>
</p>

## About the project

The control offers the functionality to de-/activate the ventilation for a amount of time, a timespan or just based on the moisture of the air from the hay. It uses Python with flask as server-side framework and uses the GPIO-Pins of the raspberry to de-/activate the ventilation.

Please note, that the minimum time, the ventilator can be deactivated is **10 minutes**! Otherwise, it can overheat and cause serious damage.


### Roadmap


##### Server

- [ ] Database
- [ ] Models (Code)
  - [ ] Intervals
  - [ ] RPM
  - [ ] Scans
- [ ] ORM
  - [ ] Intervals
  - [ ] RPM
  - [ ] Scans
- [ ] API for Models
  - [ ] Intervals
  - [ ] RPM
  - [ ] Scans


##### Recorder

- [ ] Connect Humidity Sensor
  - [ ] Read Data
  - [ ] Parse Data
- [ ] Connect RPM
  - [ ] Read Data
  - [ ] Parse Data


##### Client

- [ ] Home
  - [ ] Statistics
  - [ ] Realtime Data
- [ ] Navbar
  - [ ] Current acting-mode
- [ ] Automation
  - [ ] Parameter adjustment
    - [ ] Humidity
    - [ ] Interval on
    - [ ] Interval off
- [ ] Interval
  - [ ] Enter Interval
  - [ ] Pretty UI
- [ ] Settings
- [ ] About


<details><summary>GPIO-Pinout</summary>


| PIN | PIN-Name | Purpose                           |
| ----: | :--------- | :---------------------------------- |
|  11 | GPIO17   | Relais-Output 3                   |
|  13 | GPIO27   | Relais-Output 2                   |
|  15 | GPIO22   | Relais-Output 1                   |
|  16 | GPIO23   | Relais-Output 4                   |
|  27 | GPIO00   | SDA I2C                           |
|  28 | GPIO07   | SCL I2C                           |
|  36 | GPIO16   | Hall sensor 1                     |
|  38 | GPIO20   | Hall sensor 2 (probably not used) |


## Installation

Enter a step by step explanation for installing this repository on a local machine.

Clone the repository.

```BASH
git clone https://github.com/Baumbart13/HayVentilation.git
```

Run the desired Project with ``dotnet``

```BASH
dotnet --project HayVentilation.Server    # API
dotnet --project HayVentilation.Recorder  # Providing data do DB
dotnet --project HayVentilation.Client    # Webapp
```

## Contact

If you have any questions about this project, please feel free to contact me through [issues](https://github.com/Baumbart13/HayVentilation/issues)
