# 2018RLComparison
Comparing IMPALA and APE-X Algorithms against Atari Games

# Games

Tested with Alien, Montezuma's Revenge, and Ms. Pacman

# MACHINE

Google Cloud n1-highmem-16 (8 vCPUs, 54 GB memory) with CPU platform and 1 x NVIDIA Tesla K80 GPUs running

Debian GNU/Linux 9.6 (stretch) (GNU/Linux 4.9.0-8-amd64 x86_64\n) -- Deep Learning OS Option

Pytorch Nightly version for November 20, 2018.

Python 3.7

CUDA 9.2

# IMPALA Framework

Using AdeptRL for impala. (https://github.com/heronsystems/adeptRL). Had to change ._all_buffers() to .buffers(). Command run was 

    mpiexec -n 9 python -m adept.scripts.impala ActorCriticVtrace --env-id MsPacmanNoFrameskip-v4 --gpu-id 0 2>&1 | tee mspacman.txt

Where env-id changes to each game tested.

# Comparable Papers

https://arxiv.org/pdf/1710.02298.pdf





