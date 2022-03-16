#!/usr/bin/env python
import shutil
import psutil


def check_disk_usage(disk):
    c = shutil.disk_usage(disk)
    percent_free = c.free/c.total*100
    return percent_free > 20


def check_cpu_usage():
    usage = psutil.cpu_percent(1)
    return usage < 75


if not check_disk_usage("C:") or not check_cpu_usage():
    print("ERROR!")
else:
    print("Everything is OK!")
