import numpy as np
import torch # derin öğrenme ve sinir ağları için kullandım. 
import torch.nn as nn
import torch.nn.functional as F
import torch.optim as optim # ağırlıkları güncellemek için . 
from torch_geometric.data import Data # düğümler , kenarlar ve diğer özellikler iin . 
from torch_geometric.nn import GCNConv

# Verileri tanımla
yil = np.array([2002, 2004, 2007, 2009, 2011, 2014, 2015, 2018, 2019, 2023,2024]).reshape(-1, 1)
oy = np.array([10808229, 13447287, 16340534, 15353553, 21399082, 19469840, 18867411, 21338693, 19766640, 19392462, 16341212])

# Grafik yapısını oluştur
edges = [(i, i + 1) for i in range(len(yil) - 1)]  # Ardışık yıllar arasında kenar oluşturdum.
edges = torch.tensor(list(zip(*edges)), dtype=torch.long) #tensorlara dönüştürdüm. veri temsili matematiksel hesaplamalar için. 
x = torch.tensor(yil, dtype=torch.float).view(-1, 1)
y = torch.tensor(oy, dtype=torch.float)

graph = Data(x=x, edge_index=edges, y=y)

# Daha büyük bir GNN modeli oluştur
class BigNet(nn.Module): # 4 katmanlı bir GCN modeli tanımladım. 
    def __init__(self):
        super(BigNet, self).__init__()
        self.conv1 = GCNConv(1, 256)  # 1 input feature, 256 output features
        self.conv2 = GCNConv(256, 128)  # 256 input features, 128 output features
        self.conv3 = GCNConv(128, 64)  # 128 input features, 64 output features
        self.conv4 = GCNConv(64, 1)  # 64 input features, 1 output features
        self.dropout = nn.Dropout(0.2)  # overfitting i önlemek için. random. 

    def forward(self, data): # düğümler ve kenar bilgileri x değişkenie tanımlandı.
        x, edge_index = data.x, data.edge_index
        x = self.conv1(x, edge_index)
        x = F.relu(x)
        x = self.dropout(x)
        x = self.conv2(x, edge_index)
        x = F.relu(x)
        x = self.dropout(x)
        x = self.conv3(x, edge_index)
        x = F.relu(x)
        x = self.dropout(x)
        x = self.conv4(x, edge_index)
        return x

# Modeli oluştur
model = BigNet()

# Kayıp fonksiyonu ve optimizer tanımla
criterion = nn.MSELoss()
optimizer = optim.Adam(model.parameters(), lr=0.001)  # Öğrenme oranını artır

# Eğitim
def train_model(model, graph, optimizer, criterion, epochs=2000):  # Epoch değerini değiştirmeden eğitim
    model.train()
    for epoch in range(epochs):
        optimizer.zero_grad()
        out = model(graph)
        loss = criterion(out[:-1], graph.y.view(-1, 1)[:-1])  # Son yılı eğitimden çıkar
        loss.backward()
        optimizer.step()
        if (epoch+1) % 100 == 0:
            print(f'Epoch {epoch+1}, Loss: {loss.item()}')

# Modeli eğit
train_model(model, graph, optimizer, criterion)

# Tahmin
def predict(model, graph, year):
    with torch.no_grad():
        model.eval()
        year_tensor = torch.tensor([[year]], dtype=torch.float)
        out = model(graph)
        return out[-1][0].item()  # Son çıktıyı al, tahmini döndür

# 2024 seçiminde AKP'nin alacağı oy sayısını tahmin et
predicted_oy_2024 = predict(model, graph, 2024)
print("Bir sonraki seçimde AKP'nin tahmini oy sayısı:", int(predicted_oy_2024))


