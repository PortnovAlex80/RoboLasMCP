"""Draw reproducible Robur menu icons as SVG and transparent DPI-specific PNGs.

Run with Python and Pillow. Each command has a distinct silhouette; colours
reinforce its meaning. The same geometry generates the editable SVG and PNG.
"""
from pathlib import Path
from html import escape
import json
import math
from PIL import Image, ImageDraw, ImageFont

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / 'RobolasIcons' / 'commands'
INK, BLUE, RED, GREEN, ORANGE, PURPLE = '#334155', '#1684c7', '#cf3e46', '#22845c', '#c17a12', '#8060b3'
PALE = '#e5f3fb'
ICONS = {}


class Icon:
    def __init__(self):
        self.parts = []
        self.image = Image.new('RGBA', (256, 256))
        self.draw = ImageDraw.Draw(self.image)

    def points(self, pts):
        return [(round(x * 8), round(y * 8)) for x, y in pts]

    def line(self, pts, colour=INK, width=1.8):
        self.parts.append(f'<polyline points="{" ".join(f"{x},{y}" for x,y in pts)}" fill="none" stroke="{colour}" stroke-width="{width}" stroke-linecap="round" stroke-linejoin="round"/>')
        p = self.points(pts)
        self.draw.line(p, fill=colour, width=round(width * 8), joint='curve')
        r = width * 4
        for x, y in p:
            self.draw.ellipse((x-r, y-r, x+r, y+r), fill=colour)

    def polygon(self, pts, colour=BLUE, fill=PALE, width=1.8):
        self.parts.append(f'<polygon points="{" ".join(f"{x},{y}" for x,y in pts)}" fill="{fill or "none"}" stroke="{colour}" stroke-width="{width}" stroke-linejoin="round"/>')
        if fill:
            self.draw.polygon(self.points(pts), fill=fill)
        # Render the outline with the same rounded joints as SVG.
        saved = len(self.parts)
        self.line(pts + [pts[0]], colour, width)
        del self.parts[saved:]

    def circle(self, x, y, r, fill=BLUE):
        self.parts.append(f'<circle cx="{x}" cy="{y}" r="{r}" fill="{fill}"/>')
        self.draw.ellipse(((x-r)*8, (y-r)*8, (x+r)*8, (y+r)*8), fill=fill)

    def arrow(self, start, end, colour=BLUE):
        self.line([start, end], colour, 2.2)
        x,y=end; dx,dy=start[0]-x,start[1]-y
        length=math.hypot(dx,dy); dx,dy=dx/length,dy/length
        self.line([(x+dx*4-dy*3,y+dy*4+dx*3),end,(x+dx*4+dy*3,y+dy*4-dx*3)], colour, 2.2)

    def save(self, name, command):
        self.parts.insert(0, f'<title>{escape(command)}</title>')
        (OUT / f'{name}.svg').write_text('<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 32 32">\n'+'\n'.join(self.parts)+'\n</svg>\n', encoding='utf-8')
        for dp in (16,32):
            for scale in (1,1.5,2,2.5,3):
                size=round(dp*scale)
                self.image.resize((size,size), Image.Resampling.LANCZOS).save(OUT / f'{name}_{dp}dp_{scale:g}x.png')
        ICONS[command]=(name,self.image)


def contour(i, crs=False):
    pts=[(3,21),(9,11),(16,17),(24,8),(26,24)] if crs else [(4,9),(15,4),(25,11),(21,26),(6,24)]
    i.polygon(pts)


def pencil(i):
    i.polygon([(18,24),(25,17),(29,21),(22,28),(17,29)], ORANGE, '#ffe2a6', 1.5)
    i.line([(25,17),(29,21)], INK, 1.5)


def mesh(i):
    i.polygon([(3,25),(8,12),(15,6),(24,13),(29,25)], BLUE, PALE)
    i.line([(3,25),(16,18),(29,25),(24,13),(16,18),(15,6),(8,12),(16,18)], BLUE, 1.2)
    i.line([(8,12),(3,25)], BLUE, 1.2)


def document(i):
    i.polygon([(4,4),(16,4),(21,9),(21,27),(4,27)], INK, '#f3f7fa', 1.6)
    i.line([(16,4),(16,9),(21,9)], INK, 1.2)
    i.polygon([(7,15),(12,11),(17,17),(13,23),(7,21)], BLUE, PALE, 1.3)


def generate():
    OUT.mkdir(parents=True,exist_ok=True)
    for command in ('create_las_settings_panel','set_split_merge_tolerance','las_start_mcp'):
        i=Icon()
        if command=='create_las_settings_panel':
            for y,x in [(7,11),(16,23),(25,15)]:
                i.line([(4,y),(28,y)], INK)
                i.circle(x,y,3.5,BLUE);i.circle(x,y,1.3,'#ffffff')
        elif command == 'las_start_mcp':
            i.line([(6,9),(16,16),(26,9)], BLUE, 2)
            i.line([(6,25),(16,16),(26,25)], GREEN, 2)
            for x,y in [(6,9),(6,25),(26,9),(26,25)]:i.circle(x,y,3,BLUE)
            i.circle(16,16,4,GREEN)
        else:
            i.line([(5,5),(5,25),(27,25),(27,5)], INK, 2)
            i.line([(10,9),(22,9)], ORANGE, 2)
            i.line([(10,5),(10,14)], BLUE, 2);i.line([(22,5),(22,14)], BLUE, 2)
            for x in (10,15,20):i.line([(x,22),(x,25)],INK,1.3)
        i.save('rl_'+command,command)
    for command in ('calculation_async_section','calculation_async_one_meter_section','calculation_async_custom_step'):
        i=Icon();mesh(i)
        if command=='calculation_async_section':
            for x,y in [(7,22),(16,18),(24,22)]:i.circle(x,y,2,BLUE)
        elif command=='calculation_async_one_meter_section':
            i.line([(7,28),(25,28)],GREEN,2)
            for x in (7,13,19,25):i.line([(x,26),(x,30)],GREEN,1.6)
        else:
            i.line([(7,28),(25,28)],ORANGE,2)
            for x in (7,11,25):i.line([(x,25),(x,30)],ORANGE,1.6)
            i.circle(27,7,3,ORANGE)
        i.save('rl_'+command,command)
    for command in ('reduce_las_async_to_percent','reduce_with_ground_red_sector','split_las_by_offset'):
        i=Icon()
        if command=='split_las_by_offset':
            i.polygon([(12,3),(20,3),(20,29),(12,29)],GREEN,'#d9f1e5',1.5)
            i.line([(16,5),(16,27)],INK,1.2)
            i.arrow((10,16),(3,16),BLUE);i.arrow((22,16),(29,16),ORANGE)
        else:
            for x,y in [(4,5),(11,4),(18,6),(6,11),(14,10),(23,4)]:i.circle(x,y,1.5,BLUE)
            i.arrow((12,14),(12,22),INK)
            if command=='reduce_las_async_to_percent':
                for x,y in [(5,27),(13,25),(24,27)]:i.circle(x,y,2.2,BLUE)
                i.line([(24,13),(29,18)],ORANGE,2);i.line([(29,13),(24,18)],ORANGE,2)
            else:
                i.line([(3,28),(9,25),(18,26),(29,22)],GREEN,2.5)
                for x,y in [(5,27),(14,25),(25,23)]:i.circle(x,y,2,GREEN)
        i.save('rl_'+command,command)
    for prefix in ('plan','crs'):
        commands=[prefix+('_draw_polygon' if prefix=='plan' else '_draw_line'),prefix+'_delete_points',prefix+'_clear_polygons']
        for command in commands:
            i=Icon();contour(i,prefix=='crs')
            if '_draw_' in command:
                pencil(i)
                for x,y in ([(3,21),(9,11),(24,8)] if prefix=='crs' else [(4,9),(15,4),(6,24)]):i.circle(x,y,1.8,BLUE)
            elif '_delete_points' in command:
                for x,y in [(10,13),(14,20),(20,13)]:i.circle(x,y,1.7,BLUE)
                i.circle(24,24,6,'#ffffff')
                i.line([(20,20),(28,28)],RED,2.6);i.line([(28,20),(20,28)],RED,2.6)
            else:
                i.polygon([(20,17),(29,17),(28,29),(21,29)],RED,'#ffe7e9',1.6)
                i.line([(19,16),(30,16)],RED,2)
                i.line([(22,13),(27,13)],RED,2)
                i.line([(23,20),(23,26)],RED,1.2);i.line([(26,20),(26,26)],RED,1.2)
            i.save('rl_'+command,command)
    for command in ('polygon_save_as','polygon_load'):
        i=Icon();document(i)
        if command == 'polygon_save_as':i.arrow((17,17),(29,17),ORANGE)
        else:
            i.arrow((29,13),(17,13),GREEN)
            i.line([(22,25),(25,28),(30,22)],GREEN,2.4)
        i.save('rl_'+command,command)
    for command in ('plan_polygon_grid_surface','plan_polygon_polynomial_surface'):
        i=Icon()
        if '_grid_' in command:
            i.polygon([(4,5),(28,5),(28,28),(4,28)],BLUE,PALE)
            for x in (12,20):i.line([(x,5),(x,28)],BLUE,1.3)
            for y in (13,21):i.line([(4,y),(28,y)],BLUE,1.3)
            for x,y in [(4,5),(12,21),(28,28)]:i.circle(x,y,2,INK)
        else:
            i.line([(4,4),(4,28),(29,28)],INK,1.6)
            curve=[(5+24*t/40,22-12*math.sin(t/40*math.pi)) for t in range(41)]
            i.line(curve,PURPLE,2.8)
            for x,y in [(7,20),(12,15),(20,12),(26,18)]:i.circle(x,y,1.8,BLUE)
        i.save('rl_'+command,command)


def preview():
    font=ImageFont.truetype('C:/Windows/Fonts/segoeui.ttf',16)
    sheet=Image.new('RGB',(1040,math.ceil(len(ICONS)/3)*126),'#ffffff')
    draw=ImageDraw.Draw(sheet)
    manifest=json.loads((ROOT/'LAS_TERRAIN.plugin').read_text(encoding='utf-8'))
    titles={a['cmd']:a['title'] for a in manifest['actions'].values()}
    for n,(command,(name,icon)) in enumerate(ICONS.items()):
        x=(n%3)*344+12;y=(n//3)*126+10
        sheet.paste(icon.resize((64,64),Image.Resampling.LANCZOS),(x,y),icon.resize((64,64),Image.Resampling.LANCZOS))
        small=icon.resize((16,16),Image.Resampling.LANCZOS)
        sheet.paste(small,(x+80,y+24),small)
        dark=Image.new('RGBA',(40,40),'#252b33');dark.alpha_composite(icon.resize((32,32),Image.Resampling.LANCZOS),(4,4))
        sheet.paste(dark.convert('RGB'),(x+110,y+12))
        title=titles[command]
        # Wrap at words so the preview is readable without cutting labels.
        lines=['']
        for word in title.split():
            if draw.textlength(lines[-1]+' '+word,font=font)>320:lines.append(word)
            else:lines[-1]=(lines[-1]+' '+word).strip()
        draw.multiline_text((x,y+70),'\n'.join(lines),font=font,fill=INK,spacing=1)
    previews=ROOT/'docs'/'ui'
    previews.mkdir(parents=True,exist_ok=True)
    sheet.save(previews/'menu-icons-preview.png')


if __name__=='__main__':
    generate()
    preview()
    print(f'Drawn {len(ICONS)} distinct SVG icons and {len(ICONS)*10} transparent PNG variants in {OUT}')
