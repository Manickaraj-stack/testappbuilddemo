# CodeFirst.Tests.TaskManagerTest+GetTasks
__Test to ensure that a minimal throughput test can be rapidly executed.__
_13-10-2019 03:09:03_
### System Info
```ini
NBench=NBench, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null
OS=Microsoft Windows NT 6.2.9200.0
ProcessorCount=4
CLR=4.0.30319.42000,IsMono=False,MaxGcGeneration=2
```

### NBench Settings
```ini
RunMode=Throughput, TestMode=Test
NumberOfIterations=1, MaximumRunTime=00:00:01
Concurrent=False
Tracing=True
```

## Data
-------------------

### Totals
|          Metric |           Units |             Max |         Average |             Min |          StdDev |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|[Counter] TestCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|[Counter] TestCounter |      operations |            0.00 |            0.00 |            0.00 |            0.00 |

### Raw Data
#### [Counter] TestCounter
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  9486,98,700.00 |


## Traces
[NBench][DEBUG][13-10-2019 03:08:57][Thread 0001] Beginning Warmups for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][DEBUG][13-10-2019 03:08:57][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][13-10-2019 03:08:57][Thread 0001] Invoking setup for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][DEBUG][13-10-2019 03:08:57][Thread 0001] Throughput mode: estimating how many invocations of CodeFirst.Tests.TaskManagerTest+GetTasks will take 1s
[NBench][DEBUG][13-10-2019 03:09:01][Thread 0001] Throughput mode: executed 20983 instances of CodeFirst.Tests.TaskManagerTest+GetTasks in roughly 1s. Using that figure for benchmark.
[NBench][INFO][13-10-2019 03:09:01][Thread 0001] Invoking cleanup for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:01][Thread 0001] Generating report for warmup 1 of CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][DEBUG][13-10-2019 03:09:01][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][13-10-2019 03:09:01][Thread 0001] ----- BEGIN WARMUPS -----
[NBench][INFO][13-10-2019 03:09:01][Thread 0001] Invoking setup for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:01][Thread 0001] Invoking CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:02][Thread 0001] Invoking cleanup for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:02][Thread 0001] Generating report for warmup 1 of CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][DEBUG][13-10-2019 03:09:02][Thread 0001] ----- END WARMUPS -----
[NBench][INFO][13-10-2019 03:09:02][Thread 0001] Invoking setup for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:02][Thread 0001] Invoking CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:03][Thread 0001] Invoking cleanup for CodeFirst.Tests.TaskManagerTest+GetTasks
[NBench][INFO][13-10-2019 03:09:03][Thread 0001] Generating report for run 1 of CodeFirst.Tests.TaskManagerTest+GetTasks


