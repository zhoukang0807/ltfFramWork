// Code generated by protoc-gen-go. DO NOT EDIT.
// source: loc.proto

package msg

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion2 // please upgrade the proto package

type Location struct {
	FromX                int32    `protobuf:"varint,1,opt,name=fromX,proto3" json:"fromX,omitempty"`
	FromY                int32    `protobuf:"varint,2,opt,name=fromY,proto3" json:"fromY,omitempty"`
	ToX                  int32    `protobuf:"varint,3,opt,name=toX,proto3" json:"toX,omitempty"`
	ToY                  int32    `protobuf:"varint,4,opt,name=toY,proto3" json:"toY,omitempty"`
	Direction            string   `protobuf:"bytes,5,opt,name=direction,proto3" json:"direction,omitempty"`
	Speed                float64  `protobuf:"fixed64,6,opt,name=speed,proto3" json:"speed,omitempty"`
	Player               string   `protobuf:"bytes,7,opt,name=player,proto3" json:"player,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *Location) Reset()         { *m = Location{} }
func (m *Location) String() string { return proto.CompactTextString(m) }
func (*Location) ProtoMessage()    {}
func (*Location) Descriptor() ([]byte, []int) {
	return fileDescriptor_loc_6565650c84f9bf73, []int{0}
}
func (m *Location) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Location.Unmarshal(m, b)
}
func (m *Location) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Location.Marshal(b, m, deterministic)
}
func (dst *Location) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Location.Merge(dst, src)
}
func (m *Location) XXX_Size() int {
	return xxx_messageInfo_Location.Size(m)
}
func (m *Location) XXX_DiscardUnknown() {
	xxx_messageInfo_Location.DiscardUnknown(m)
}

var xxx_messageInfo_Location proto.InternalMessageInfo

func (m *Location) GetFromX() int32 {
	if m != nil {
		return m.FromX
	}
	return 0
}

func (m *Location) GetFromY() int32 {
	if m != nil {
		return m.FromY
	}
	return 0
}

func (m *Location) GetToX() int32 {
	if m != nil {
		return m.ToX
	}
	return 0
}

func (m *Location) GetToY() int32 {
	if m != nil {
		return m.ToY
	}
	return 0
}

func (m *Location) GetDirection() string {
	if m != nil {
		return m.Direction
	}
	return ""
}

func (m *Location) GetSpeed() float64 {
	if m != nil {
		return m.Speed
	}
	return 0
}

func (m *Location) GetPlayer() string {
	if m != nil {
		return m.Player
	}
	return ""
}

func init() {
	proto.RegisterType((*Location)(nil), "msg.Location")
}

func init() { proto.RegisterFile("loc.proto", fileDescriptor_loc_6565650c84f9bf73) }

var fileDescriptor_loc_6565650c84f9bf73 = []byte{
	// 156 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xe2, 0xe2, 0xcc, 0xc9, 0x4f, 0xd6,
	0x2b, 0x28, 0xca, 0x2f, 0xc9, 0x17, 0x62, 0xce, 0x2d, 0x4e, 0x57, 0x5a, 0xc6, 0xc8, 0xc5, 0xe1,
	0x93, 0x9f, 0x9c, 0x58, 0x92, 0x99, 0x9f, 0x27, 0x24, 0xc2, 0xc5, 0x9a, 0x56, 0x94, 0x9f, 0x1b,
	0x21, 0xc1, 0xa8, 0xc0, 0xa8, 0xc1, 0x1a, 0x04, 0xe1, 0xc0, 0x44, 0x23, 0x25, 0x98, 0x10, 0xa2,
	0x91, 0x42, 0x02, 0x5c, 0xcc, 0x25, 0xf9, 0x11, 0x12, 0xcc, 0x60, 0x31, 0x10, 0x13, 0x22, 0x12,
	0x29, 0xc1, 0x02, 0x13, 0x89, 0x14, 0x92, 0xe1, 0xe2, 0x4c, 0xc9, 0x2c, 0x4a, 0x4d, 0x06, 0x19,
	0x2e, 0xc1, 0xaa, 0xc0, 0xa8, 0xc1, 0x19, 0x84, 0x10, 0x00, 0x99, 0x5b, 0x5c, 0x90, 0x9a, 0x9a,
	0x22, 0xc1, 0xa6, 0xc0, 0xa8, 0xc1, 0x18, 0x04, 0xe1, 0x08, 0x89, 0x71, 0xb1, 0x15, 0xe4, 0x24,
	0x56, 0xa6, 0x16, 0x49, 0xb0, 0x83, 0x35, 0x40, 0x79, 0x49, 0x6c, 0x60, 0x47, 0x1b, 0x03, 0x02,
	0x00, 0x00, 0xff, 0xff, 0x5a, 0x44, 0x39, 0xdf, 0xc1, 0x00, 0x00, 0x00,
}
