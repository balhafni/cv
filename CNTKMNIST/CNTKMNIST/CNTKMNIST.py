import sys
from DeepCNNMNIST import DeepCNNMNIST
def main():
    deepCNNforMNIST = DeepCNNMNIST()
    deepCNNforMNIST.driver()
if __name__ == "__main__":
    sys.exit(int(main() or 0))