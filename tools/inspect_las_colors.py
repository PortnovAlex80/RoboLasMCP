"""Read-only LAS header/RGB sampling. No cloud records are modified."""
import argparse,json,struct
from pathlib import Path

RGB_OFFSETS={2:20,3:28,5:28,7:30,8:30,10:30}
def inspect(path):
    path=Path(path)
    with path.open('rb') as stream:
        header=stream.read(375)
        if header[:4]!=b'LASF' or len(header)<227:
            return {'path':str(path),'error':'not a complete LAS header'}
        fmt=header[104]&63
        compressed=bool(header[104]&128)
        count=struct.unpack_from('<I',header,107)[0]
        if header[25]>=4 and len(header)>=255:
            count=struct.unpack_from('<Q',header,247)[0] or count
        offset=struct.unpack_from('<I',header,96)[0]
        length=struct.unpack_from('<H',header,105)[0]
        result={'path':str(path),'bytes':path.stat().st_size,'version':f'{header[24]}.{header[25]}',
                'point_format':fmt,'record_length':length,'point_count':count,'compressed':compressed,'has_rgb':fmt in RGB_OFFSETS}
        if not compressed and fmt in RGB_OFFSETS and length>=RGB_OFFSETS[fmt]+6 and count:
            samples=[]
            for index in sorted(set([0,count//4,count//2,3*count//4,count-1])):
                stream.seek(offset+index*length)
                point=stream.read(length)
                if len(point)!=length: result['error']='truncated point data'; break
                samples.append({'point_index':index,'rgb16':struct.unpack_from('<HHH',point,RGB_OFFSETS[fmt])})
            result['samples']=samples
        return result

if __name__=='__main__':
    parser=argparse.ArgumentParser(description=__doc__)
    parser.add_argument('root',type=Path)
    parser.add_argument('--output',type=Path)
    args=parser.parse_args()
    paths=[args.root] if args.root.is_file() else sorted(args.root.rglob('*.las'))
    report=[]
    for path in paths:
        try: report.append(inspect(path))
        except OSError as error: report.append({'path':str(path),'error':str(error)})
    if args.output: args.output.write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
    print(json.dumps(report,ensure_ascii=True,indent=2))
