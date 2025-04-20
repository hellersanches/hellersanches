import os

# Tipos de arquivos que vamos converter
EXTENSIONS = ['.py', '.txt', '.md']

def convert_file_to_utf8(filepath):
    try:
        with open(filepath, 'rb') as f:
            raw = f.read()
        try:
            # tenta ler com utf-8
            raw.decode('utf-8')
            print(f"✓ {filepath} já está em UTF-8")
        except UnicodeDecodeError:
            # tenta ler com ISO-8859-1 ou Windows-1252 (comum no Windows)
            text = raw.decode('latin-1')
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(text)
            print(f"✔ Convertido: {filepath}")
    except Exception as e:
        print(f"⚠ Erro ao processar {filepath}: {e}")

def walk_and_convert(root='.'):
    for folder, _, files in os.walk(root):
        for file in files:
            if any(file.endswith(ext) for ext in EXTENSIONS):
                convert_file_to_utf8(os.path.join(folder, file))

if __name__ == '__main__':
    walk_and_convert()
